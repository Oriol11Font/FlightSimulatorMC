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
    public partial class SystemVerification : Form
    {
        public SystemVerification()
        {
            InitializeComponent();
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
    }
}
