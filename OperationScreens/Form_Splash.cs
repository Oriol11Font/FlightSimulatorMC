using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
