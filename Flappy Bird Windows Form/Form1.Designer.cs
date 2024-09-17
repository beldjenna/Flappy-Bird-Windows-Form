namespace Flappy_Bird_Windows_Form
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
            pipeBottom = new PictureBox();
            flappyBird = new PictureBox();
            ground = new PictureBox();
            pipeTop = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            SuspendLayout();
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(371, 371);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(95, 217);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 0;
            pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.icons8_flappy_dunk_80;
            flappyBird.Location = new Point(96, 238);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(77, 68);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            flappyBird.Click += pictureBox2_Click;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(0, 585);
            ground.Name = "ground";
            ground.Size = new Size(735, 96);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 2;
            ground.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(579, -3);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(95, 208);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 3;
            pipeTop.TabStop = false;
            pipeTop.Click += pipeTop_Click;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(44, 31);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(129, 38);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score : 0";
            scoreText.Click += label1_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(734, 672);
            Controls.Add(scoreText);
            Controls.Add(pipeTop);
            Controls.Add(ground);
            Controls.Add(flappyBird);
            Controls.Add(pipeBottom);
            Name = "Form1";
            Text = "Flappy Bird";
            Load += Form1_Load;
            KeyDown += gameKeyIsDown;
            KeyUp += gameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeBottom;
        private PictureBox flappyBird;
        private PictureBox ground;
        private PictureBox pipeTop;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
