namespace Noise_Launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timerUpdateTimeDate = new System.Windows.Forms.Timer(components);
            upPanel = new Panel();
            spliter = new Panel();
            labelDate = new Label();
            labelTime = new Label();
            buttonLibrary = new Button();
            buttonNoise = new Button();
            buttonMinimize = new Button();
            buttonExit = new Button();
            downPanel = new Panel();
            buttonDelete = new Button();
            buttonAddition = new Button();
            splitContainer1 = new SplitContainer();
            gameList = new FlowLayoutPanel();
            splitContainer2 = new SplitContainer();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            panelGameDetails = new Panel();
            buttonProperties = new Button();
            labelGameTime = new Label();
            buttonPlay = new Button();
            panelAboutProgram = new Panel();
            labelInfo = new Label();
            buttonBack = new Button();
            panelNoise = new Panel();
            buttonSettings = new Button();
            buttonExitDublicate = new Button();
            buttonAboutProgram = new Button();
            panelSettings = new Panel();
            DropDawn = new ComboBox();
            labelSettings = new Label();
            panelChooseGame = new Panel();
            labelChooseGame = new Label();
            upPanel.SuspendLayout();
            downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGameDetails.SuspendLayout();
            panelAboutProgram.SuspendLayout();
            panelNoise.SuspendLayout();
            panelSettings.SuspendLayout();
            panelChooseGame.SuspendLayout();
            SuspendLayout();
            // 
            // timerUpdateTimeDate
            // 
            timerUpdateTimeDate.Enabled = true;
            timerUpdateTimeDate.Tick += timerUpdateTimeDate_Tick;
            // 
            // upPanel
            // 
            upPanel.BackColor = Color.FromArgb(15, 15, 15);
            upPanel.Controls.Add(spliter);
            upPanel.Controls.Add(labelDate);
            upPanel.Controls.Add(labelTime);
            upPanel.Controls.Add(buttonLibrary);
            upPanel.Controls.Add(buttonNoise);
            upPanel.Controls.Add(buttonMinimize);
            upPanel.Controls.Add(buttonExit);
            upPanel.Dock = DockStyle.Top;
            upPanel.Location = new Point(0, 0);
            upPanel.Name = "upPanel";
            upPanel.Size = new Size(1366, 80);
            upPanel.TabIndex = 0;
            // 
            // spliter
            // 
            spliter.BackColor = Color.Silver;
            spliter.Location = new Point(1068, 6);
            spliter.Name = "spliter";
            spliter.Size = new Size(2, 25);
            spliter.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.FlatStyle = FlatStyle.Flat;
            labelDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDate.ForeColor = Color.Silver;
            labelDate.Location = new Point(1072, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(100, 30);
            labelDate.TabIndex = 5;
            labelDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTime
            // 
            labelTime.FlatStyle = FlatStyle.Flat;
            labelTime.Font = new Font("Segoe UI", 18F);
            labelTime.ForeColor = Color.Silver;
            labelTime.Location = new Point(986, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(80, 30);
            labelTime.TabIndex = 4;
            labelTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonLibrary
            // 
            buttonLibrary.FlatAppearance.BorderSize = 0;
            buttonLibrary.FlatStyle = FlatStyle.Flat;
            buttonLibrary.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLibrary.ForeColor = Color.Cyan;
            buttonLibrary.Location = new Point(3, 34);
            buttonLibrary.Name = "buttonLibrary";
            buttonLibrary.Size = new Size(170, 43);
            buttonLibrary.TabIndex = 3;
            buttonLibrary.Text = "Library";
            buttonLibrary.TextAlign = ContentAlignment.MiddleLeft;
            buttonLibrary.UseVisualStyleBackColor = true;
            // 
            // buttonNoise
            // 
            buttonNoise.FlatAppearance.BorderSize = 0;
            buttonNoise.FlatStyle = FlatStyle.Flat;
            buttonNoise.Font = new Font("Segoe UI", 12F);
            buttonNoise.ForeColor = Color.Silver;
            buttonNoise.Location = new Point(3, 3);
            buttonNoise.Name = "buttonNoise";
            buttonNoise.Size = new Size(65, 25);
            buttonNoise.TabIndex = 2;
            buttonNoise.Text = "Noise";
            buttonNoise.TextAlign = ContentAlignment.TopCenter;
            buttonNoise.UseVisualStyleBackColor = true;
            buttonNoise.Click += buttonNoise_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMinimize.ForeColor = Color.DarkGray;
            buttonMinimize.Location = new Point(1286, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(40, 40);
            buttonMinimize.TabIndex = 1;
            buttonMinimize.Text = "-";
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.ForeColor = Color.DarkGray;
            buttonExit.Location = new Point(1326, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(40, 40);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // downPanel
            // 
            downPanel.BackColor = Color.FromArgb(17, 17, 17);
            downPanel.Controls.Add(buttonDelete);
            downPanel.Controls.Add(buttonAddition);
            downPanel.Dock = DockStyle.Bottom;
            downPanel.Location = new Point(0, 708);
            downPanel.Name = "downPanel";
            downPanel.Size = new Size(1366, 60);
            downPanel.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 32F);
            buttonDelete.ForeColor = Color.Silver;
            buttonDelete.Location = new Point(1216, 0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 60);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "-: OFF";
            buttonDelete.TextAlign = ContentAlignment.TopCenter;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddition
            // 
            buttonAddition.FlatAppearance.BorderSize = 0;
            buttonAddition.FlatStyle = FlatStyle.Flat;
            buttonAddition.Font = new Font("Segoe UI", 32F);
            buttonAddition.ForeColor = Color.Silver;
            buttonAddition.Location = new Point(0, 0);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(150, 60);
            buttonAddition.TabIndex = 0;
            buttonAddition.Text = "+";
            buttonAddition.TextAlign = ContentAlignment.TopCenter;
            buttonAddition.UseVisualStyleBackColor = true;
            buttonAddition.Click += buttonAddition_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gameList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1366, 708);
            splitContainer1.SplitterDistance = 249;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 2;
            // 
            // gameList
            // 
            gameList.AutoScroll = true;
            gameList.BackColor = Color.FromArgb(20, 20, 20);
            gameList.Location = new Point(0, 75);
            gameList.Name = "gameList";
            gameList.Size = new Size(249, 633);
            gameList.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(labelName);
            splitContainer2.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(panelGameDetails);
            splitContainer2.Size = new Size(1116, 708);
            splitContainer2.SplitterDistance = 394;
            splitContainer2.SplitterWidth = 1;
            splitContainer2.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.BackColor = Color.Transparent;
            labelName.FlatStyle = FlatStyle.Flat;
            labelName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.Silver;
            labelName.Location = new Point(20, 245);
            labelName.Name = "labelName";
            labelName.Size = new Size(195, 60);
            labelName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1116, 394);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelGameDetails
            // 
            panelGameDetails.BackColor = Color.FromArgb(20, 20, 20);
            panelGameDetails.Controls.Add(buttonProperties);
            panelGameDetails.Controls.Add(labelGameTime);
            panelGameDetails.Controls.Add(buttonPlay);
            panelGameDetails.Dock = DockStyle.Fill;
            panelGameDetails.Location = new Point(0, 0);
            panelGameDetails.Name = "panelGameDetails";
            panelGameDetails.Size = new Size(1116, 313);
            panelGameDetails.TabIndex = 0;
            // 
            // buttonProperties
            // 
            buttonProperties.BackColor = Color.FromArgb(17, 17, 17);
            buttonProperties.BackgroundImage = Properties.Resources.Sprite_PropertiesButton;
            buttonProperties.FlatAppearance.BorderSize = 0;
            buttonProperties.FlatStyle = FlatStyle.Flat;
            buttonProperties.Font = new Font("Segoe UI", 21.75F);
            buttonProperties.Location = new Point(1036, 17);
            buttonProperties.Name = "buttonProperties";
            buttonProperties.Size = new Size(62, 62);
            buttonProperties.TabIndex = 2;
            buttonProperties.UseVisualStyleBackColor = false;
            buttonProperties.Click += buttonProperty_Click;
            // 
            // labelGameTime
            // 
            labelGameTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGameTime.ForeColor = Color.Silver;
            labelGameTime.Location = new Point(282, 17);
            labelGameTime.Name = "labelGameTime";
            labelGameTime.Size = new Size(185, 62);
            labelGameTime.TabIndex = 1;
            labelGameTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.FromArgb(92, 164, 21);
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlay.ForeColor = Color.White;
            buttonPlay.Location = new Point(20, 17);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(195, 62);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = false;
            // 
            // panelAboutProgram
            // 
            panelAboutProgram.Controls.Add(labelInfo);
            panelAboutProgram.Location = new Point(433, 209);
            panelAboutProgram.Name = "panelAboutProgram";
            panelAboutProgram.Size = new Size(500, 350);
            panelAboutProgram.TabIndex = 2;
            panelAboutProgram.Visible = false;
            // 
            // labelInfo
            // 
            labelInfo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo.ForeColor = Color.Silver;
            labelInfo.Location = new Point(3, 23);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(497, 235);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "------------------------\r\nNoise Launcher\r\nCreated by Artyom Kharkin\r\nVersion: 1.0\r\n------------------------\r\n";
            labelInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBack.ForeColor = Color.Silver;
            buttonBack.Location = new Point(795, 500);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(130, 50);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Close";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Visible = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelNoise
            // 
            panelNoise.Controls.Add(buttonSettings);
            panelNoise.Controls.Add(buttonExitDublicate);
            panelNoise.Controls.Add(buttonAboutProgram);
            panelNoise.Location = new Point(12, 34);
            panelNoise.Name = "panelNoise";
            panelNoise.Size = new Size(201, 150);
            panelNoise.TabIndex = 7;
            panelNoise.Visible = false;
            // 
            // buttonSettings
            // 
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSettings.ForeColor = Color.Silver;
            buttonSettings.Location = new Point(0, 50);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(201, 50);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonExitDublicate
            // 
            buttonExitDublicate.FlatAppearance.BorderSize = 0;
            buttonExitDublicate.FlatStyle = FlatStyle.Flat;
            buttonExitDublicate.Font = new Font("Segoe UI", 18F);
            buttonExitDublicate.ForeColor = Color.Silver;
            buttonExitDublicate.Location = new Point(0, 100);
            buttonExitDublicate.Name = "buttonExitDublicate";
            buttonExitDublicate.Size = new Size(201, 50);
            buttonExitDublicate.TabIndex = 1;
            buttonExitDublicate.Text = "Exit";
            buttonExitDublicate.UseVisualStyleBackColor = true;
            buttonExitDublicate.Click += buttonExitDublicate_Click;
            // 
            // buttonAboutProgram
            // 
            buttonAboutProgram.FlatAppearance.BorderSize = 0;
            buttonAboutProgram.FlatStyle = FlatStyle.Flat;
            buttonAboutProgram.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAboutProgram.ForeColor = Color.Silver;
            buttonAboutProgram.Location = new Point(0, 0);
            buttonAboutProgram.Name = "buttonAboutProgram";
            buttonAboutProgram.Size = new Size(201, 50);
            buttonAboutProgram.TabIndex = 0;
            buttonAboutProgram.Text = "About program";
            buttonAboutProgram.UseVisualStyleBackColor = true;
            buttonAboutProgram.Click += buttonAboutProgram_Click;
            // 
            // panelSettings
            // 
            panelSettings.Anchor = AnchorStyles.None;
            panelSettings.Controls.Add(DropDawn);
            panelSettings.Controls.Add(labelSettings);
            panelSettings.Location = new Point(433, 209);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(500, 350);
            panelSettings.TabIndex = 8;
            panelSettings.Visible = false;
            // 
            // DropDawn
            // 
            DropDawn.BackColor = Color.FromArgb(40, 40, 40);
            DropDawn.DropDownStyle = ComboBoxStyle.DropDownList;
            DropDawn.FormattingEnabled = true;
            DropDawn.Items.AddRange(new object[] { "Русский", "English" });
            DropDawn.Location = new Point(189, 89);
            DropDawn.Name = "DropDawn";
            DropDawn.Size = new Size(121, 23);
            DropDawn.TabIndex = 2;
            DropDawn.SelectedIndexChanged += DropDawn_SelectedIndexChanged;
            // 
            // labelSettings
            // 
            labelSettings.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSettings.ForeColor = Color.Silver;
            labelSettings.Location = new Point(30, 23);
            labelSettings.Name = "labelSettings";
            labelSettings.Size = new Size(439, 48);
            labelSettings.TabIndex = 0;
            labelSettings.Text = "Settings\r\n\r\n";
            labelSettings.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelChooseGame
            // 
            panelChooseGame.Anchor = AnchorStyles.None;
            panelChooseGame.Controls.Add(labelChooseGame);
            panelChooseGame.Location = new Point(433, 209);
            panelChooseGame.Name = "panelChooseGame";
            panelChooseGame.Size = new Size(500, 350);
            panelChooseGame.TabIndex = 9;
            panelChooseGame.Visible = false;
            // 
            // labelChooseGame
            // 
            labelChooseGame.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelChooseGame.ForeColor = Color.Silver;
            labelChooseGame.Location = new Point(3, 23);
            labelChooseGame.Name = "labelChooseGame";
            labelChooseGame.Size = new Size(497, 235);
            labelChooseGame.TabIndex = 0;
            labelChooseGame.Text = "------------------------\r\nSelect a game to play...\r\n------------------------\r\n";
            labelChooseGame.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1366, 768);
            Controls.Add(buttonBack);
            Controls.Add(panelAboutProgram);
            Controls.Add(panelChooseGame);
            Controls.Add(panelSettings);
            Controls.Add(panelNoise);
            Controls.Add(upPanel);
            Controls.Add(splitContainer1);
            Controls.Add(downPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noise Launcher";
            upPanel.ResumeLayout(false);
            downPanel.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGameDetails.ResumeLayout(false);
            panelAboutProgram.ResumeLayout(false);
            panelNoise.ResumeLayout(false);
            panelSettings.ResumeLayout(false);
            panelChooseGame.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerUpdateTimeDate;
        private Panel upPanel;
        private Panel downPanel;
        private Button buttonMinimize;
        private Button buttonExit;
        private Button buttonLibrary;
        private Button buttonDelete;
        private Button buttonAddition;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel gameList;
        private Label labelName;
        private SplitContainer splitContainer2;
        private PictureBox pictureBox1;
        private Panel panelGameDetails;
        private Button buttonPlay;
        private Label labelGameTime;
        private Label labelDate;
        private Label labelTime;
        private Panel spliter;
        private Panel panelNoise;
        private Button buttonSettings;
        private Button buttonExitDublicate;
        private Button buttonAboutProgram;
        private Button buttonNoise;
        private Panel panelAboutProgram;
        private Button buttonBack;
        private Label labelInfo;
        private Panel panelSettings;
        private ComboBox DropDawn;
        private Label labelSettings;
        private Panel panelChooseGame;
        private Label labelChooseGame;
        private Button buttonProperties;
    }
}
