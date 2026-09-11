using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Noise_Launcher
{
    public class WinLoader : Control
    {
        private System.Windows.Forms.Timer timer;
        private float angle = 0;

        public WinLoader()
        {
            // Включаем двойную буферизацию, чтобы не было мерцания
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            this.Size = new Size(100, 100); // Размер области анимации
            this.BackColor = Color.FromArgb(35,35,35); // Прозрачный фон

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 15; // Скорость обновления (чем меньше, тем плавнее)
            timer.Tick += (s, e) => {
                angle += 6f; // На сколько градусов поворачивать за один шаг
                if (angle >= 360) angle = 0;
                this.Invalidate(); // Перерисовать контрол
            };
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Сглаживание

            // Сдвигаем центр рисования в середину контрола
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(angle);

            // Рисуем 6 точек
            for (int i = 0; i < 6; i++)
            {
                // Эффект затухания (хвоста)
                int alpha = 255 - (i * 40);
                if (alpha < 0) alpha = 0;

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, Color.Cyan)))
                {
                    // Расставляем точки по кругу с небольшим смещением
                    float size = 8 - i; // Хвост становится тоньше
                    if (size < 2) size = 2;

                    double x = 25 * Math.Cos(i * Math.PI / 5);
                    double y = 25 * Math.Sin(i * Math.PI / 5);

                    e.Graphics.FillEllipse(brush, (float)x, (float)y, size, size);
                }
            }
        }
    }
}