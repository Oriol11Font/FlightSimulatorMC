using System;
using System.Windows.Forms;

namespace OperationScreens
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlider.Left += 40;

            if (panelSlider.Left > 859)
            {
                panelSlider.Left = 0;
            }
            if (panelSlider.Left < 0)
            {
                //move = 2;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form_dashboard dash = new Form_dashboard();
            dash.Show();
            this.Hide();
            timer1.Stop();
            timer2.Stop();
        }
    }
}
