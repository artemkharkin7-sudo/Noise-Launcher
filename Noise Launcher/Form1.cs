using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Media;


namespace Noise_Launcher
{
    public partial class Form1 : Form
    {
        readonly string saveFile = Path.Combine(Application.StartupPath, "games.txt");
        string appPath = "";
        string selectedGamePath = "";

        bool deleteMode = false;

        private SoundPlayer hoverMouse = new SoundPlayer("hover.wav");

        public Form1()
        {
            InitializeComponent();

            InitializeAudio();
            LoadGames();

            timerUpdateTimeDate.Tick += timerUpdateTimeDate_Tick;
            timerUpdateTimeDate.Start();

            var buttons = new[] { buttonProperties, buttonDelete, buttonAddition, buttonExit, buttonMinimize, buttonLibrary, buttonNoise, buttonAboutProgram, buttonSettings, buttonExitDublicate, buttonPlay, buttonBack };
            foreach (Button button in buttons)
            {
                button.MouseEnter += GameButton_MouseEnter;
            }

            buttonPlay.Click += GameStart;

            labelName.Parent = pictureBox1;
            labelName.BackColor = Color.Transparent;

            ApplyLocalization();

            DropDawn.SelectedIndexChanged += DropDawn_SelectedIndexChanged;
            DropDawn.SelectedIndex = 0;
        }

        private void InitializeAudio()
        {
            try
            {
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                string resourceName = "Noise_Launcher.hover.wav";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        hoverMouse = new SoundPlayer(stream);
                        hoverMouse.Load();
                    }
                }
            }
            catch { }
        }

        private void ApplyLocalization()
        {
            var resources = new ComponentResourceManager(typeof(Lang.Lang));
            TranslateControls(this.Controls, resources);
        }
        private void TranslateControls(Control.ControlCollection controls, ComponentResourceManager resources)
        {
            foreach (Control control in controls)
            {
                string translatedtext = resources.GetString(control.Name);
                if (translatedtext != null)
                    control.Text = translatedtext;

                if (control.HasChildren)
                    TranslateControls(control.Controls, resources);
            }
        }
        private void ChangeLanguage(string langCode)
        {
            CultureInfo culture = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            ApplyLocalization();
            this.Refresh();
        }

        private void LoadGames()
        {
            if (!File.Exists(saveFile)) return;

            foreach (string line in File.ReadAllLines(saveFile))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                    CreateButton(parts[0]);    
            }
        }
        private void SaveGames(string path, double minutesToAdd)
        {
            var lines = new List<string>();
            bool found = false;

            if (File.Exists(saveFile))
            {
                foreach (string line in File.ReadAllLines(saveFile))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 2 && parts[0] == path)
                    {
                        double oldMinutes = double.Parse(parts[1], CultureInfo.InvariantCulture);
                        double newTotalMinutes = oldMinutes + minutesToAdd;
                        lines.Add($"{path}|{newTotalMinutes.ToString(CultureInfo.InvariantCulture)}");
                        found = true;
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
            }

            if (!found)
            {
                lines.Add($"{path}|{minutesToAdd.ToString(CultureInfo.InvariantCulture)}");
            }

            File.WriteAllLines(saveFile, lines);
        }
        private void RemoveGameFromFile(string pathToRemove)
        {
            if (!File.Exists(saveFile)) return;

            var lines = File.ReadAllLines(saveFile)
                            .Where(line => !line.StartsWith(pathToRemove + "|"))
                            .ToList();

            File.WriteAllLines(saveFile, lines);
        }
        private double GetPlayedMinutes(string path)
        {
            if (!File.Exists(saveFile)) return 0;

            var line = File.ReadLines(saveFile)
                .Select(l => l.Split('|'))
                .FirstOrDefault(p => p.Length == 2 && p[0] == path);

            if (line != null && double.TryParse(line[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                return result;  
            
            return 0;
        }

        private void CreateButton(string gamePath)
        {
            var currentGameButton = new Button
            {
                Size = new Size(230, 25),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(20, 20, 20),
                Font = new Font("SegoeUI", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.BottomCenter,
                ForeColor = Color.White,
                ImageAlign = ContentAlignment.TopLeft,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Tag = gamePath
            };

            currentGameButton.FlatAppearance.BorderSize = 0;

            double totalminutes = GetPlayedMinutes(gamePath);
            string gameName = Path.GetFileNameWithoutExtension(gamePath);

            currentGameButton.Text = $"{gameName}\n{FormatTime(totalminutes)}";
            currentGameButton.Click += NameSearcher;
            currentGameButton.MouseEnter += GameButton_MouseEnter;

            using (var originalIcon = Icon.ExtractAssociatedIcon(gamePath))
            using (var originalBitmap = originalIcon.ToBitmap())
            {
                if (originalBitmap != null)
                {
                    var resizedBitmap = new Bitmap(16, 16);
                    using (var g = Graphics.FromImage(resizedBitmap))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(originalBitmap, 0, 0, 16, 16);
                    }
                    currentGameButton.Image = resizedBitmap;
                }
            }
            gameList.Controls.Add(currentGameButton);
        }
        private void NameSearcher(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            string currentGamePath = clickedButton.Tag.ToString();

            if (deleteMode)
            {
                RemoveGameFromFile(currentGamePath);
                gameList.Controls.Remove(clickedButton);
                clickedButton.Dispose();

                //labelName.Text = "Game is deleted";
                selectedGamePath = "";
                labelGameTime.Text = "";
                return;
            }

            selectedGamePath = currentGamePath;

            string gameName = Path.GetFileNameWithoutExtension(currentGamePath);

            if (!string.IsNullOrEmpty(gameName))
            {
                gameName = char.ToUpper(gameName[0]) + gameName.Substring(1);
            }

            labelName.Text = gameName;

            double totalMinutes = GetPlayedMinutes(currentGamePath);
            labelGameTime.Text = FormatTime(totalMinutes);
        }
        private void OpenDialog()
        {
            var openExplorer = new OpenFileDialog { Filter = "Executables|*.exe" };
            if (openExplorer.ShowDialog() == DialogResult.OK) appPath = openExplorer.FileName;
        }

        private string FormatTime(double minutes)
        {
            if (minutes < 60) return $"{(int)(minutes)} мин.";
            return $"{(int)(minutes / 60)} ч. {(int)(minutes % 60)} м.";
        }
        private bool IsGameRunning(string processName)
        {
            return Process.GetProcessesByName(processName).Length > 0;
        }
        private void GameButton_MouseEnter(object? sender, EventArgs e)
        {
            try
            {
                hoverMouse.Play();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ошибка воспроизведения звука: " + ex.Message);
            }
        }
        private void GameStart(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedGamePath))
            {
                panelChooseGame.Visible = !panelChooseGame.Visible;

                panelSettings.Visible = false;
                panelAboutProgram.Visible = false;

                buttonBack.Visible = panelChooseGame.Visible;
                buttonBack.BringToFront();

                return;
            }

            string path = selectedGamePath;
            string name = Path.GetFileNameWithoutExtension(path);

            var gameProcess = new Process();
            gameProcess.StartInfo.FileName = path;
            gameProcess.StartInfo.UseShellExecute = true;
            gameProcess.EnableRaisingEvents = true;

            var stopwatch = new Stopwatch();

            gameProcess.Exited += (s, args) =>
            {
                stopwatch.Stop();
                double sessionMinutes = stopwatch.Elapsed.TotalMinutes;
                SaveGames(path, sessionMinutes);

                this.Invoke(new Action(() =>
                {
                    double newTotal = GetPlayedMinutes(path);

                    if (selectedGamePath == path)
                    {
                        labelGameTime.Text = FormatTime(newTotal);
                    }

                    this.Show();
                }));
                gameProcess.Dispose();
            };

            gameProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);

            gameProcess.Start();
            this.Hide();
            stopwatch.Start();
        }


        private void buttonNoise_Click(object sender, EventArgs e) => panelNoise.Visible = !panelNoise.Visible;
        private void buttonMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void buttonExit_Click(object sender, EventArgs e) => Application.Exit();
        private void buttonExitDublicate_Click(object sender, EventArgs e) => Application.Exit();
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            OpenDialog();
            if (!string.IsNullOrEmpty(appPath))
            {
                CreateButton(appPath);
                SaveGames(appPath, 0);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteMode = !deleteMode;
            buttonDelete.Text = deleteMode ? "-: ON" : "-: OFF";
        }
        private void buttonAboutProgram_Click(object sender, EventArgs e)
        {
            panelAboutProgram.Visible = !panelAboutProgram.Visible;

            panelChooseGame.Visible = false;
            panelSettings.Visible = false;

            buttonBack.Visible = panelAboutProgram.Visible;
            buttonBack.BringToFront();

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            var panels = new[] { panelAboutProgram, panelChooseGame, panelSettings };

            foreach (var panel in panels)
                panel.Visible = false;

            buttonBack.Visible = false;   
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = !panelSettings.Visible;

            panelChooseGame.Visible = false;
            panelAboutProgram.Visible = false;

            buttonBack.Visible = panelSettings.Visible;
            buttonBack.BringToFront();
        }
        private void buttonProperty_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedGamePath))
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo("explorer.exe", Path.GetDirectoryName(selectedGamePath));
                process.Start();
            }    
        }

        private void DropDawn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDawn.SelectedIndex == 1)
                ChangeLanguage("en");

            else
                ChangeLanguage("ru");
        }
        private void timerUpdateTimeDate_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("d MMM");
            labelTime.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
