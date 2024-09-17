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
            pipeBottom = new PictureBox();
            flappyBird = new PictureBox();
            ground = new PictureBox();
            pipeTop = new PictureBox();
            scoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            SuspendLayout();
            // 
            // pipeBottom
            // 
            pipeBottom.Location = new Point(491, 504);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(150, 75);
            pipeBottom.TabIndex = 0;
            pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Location = new Point(144, 247);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(150, 75);
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            flappyBird.Click += pictureBox2_Click;
            // 
            // ground
            // 
            ground.Location = new Point(12, 585);
            ground.Name = "ground";
            ground.Size = new Size(710, 75);
            ground.TabIndex = 2;
            ground.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Location = new Point(491, 12);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(150, 75);
            pipeTop.TabIndex = 3;
            pipeTop.TabStop = false;
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
    }
}
