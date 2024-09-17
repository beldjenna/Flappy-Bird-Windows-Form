namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 120;
            }
            if(pipeTop.Left < -80)
            {
                pipeTop.Left = 170;
            }
        
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { 

                gravity = -15;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 5;
            }

        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }
    }
}
