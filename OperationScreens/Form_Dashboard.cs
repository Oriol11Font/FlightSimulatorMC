using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationScreens
{
    public partial class Form_dashboard : Form
    {
        public Form_dashboard()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            trd.Abort();
            Show();
        }

        public void formRun ()
        {
            Application.Run(new Form_Splash());
        }

        private void SystemVerification_Load(object sender, EventArgs e)
        {
            validationProcess1.Visible = true;
            spaceShipDetails1.Visible = false;
            selectionPlanet1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validationProcess1.Visible = true;
            spaceShipDetails1.Visible = false;
            selectionPlanet1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            validationProcess1.Visible = false;
            spaceShipDetails1.Visible = false;
            selectionPlanet1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            validationProcess1.Visible = false;
            spaceShipDetails1.Visible = true;
            selectionPlanet1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
