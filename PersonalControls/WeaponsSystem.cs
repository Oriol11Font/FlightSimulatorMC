using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalControls
{
    public partial class WeaponsSystem : UserControl
    {
        public WeaponsSystem()
        {
            InitializeComponent();
        }

        readonly string ruta = Application.StartupPath + "\\assets\\targets.txt";
        Random rnd = new Random();
        private void btn_Start_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadLines(ruta).ToList();
            var lineCount = File.ReadLines(ruta).Count();

            pictureBox3.ImageLocation = "";

            int num = rnd.Next(0, lineCount-1);

            string[] spaceShip = lines[num].Split('|');

            if (spaceShip[1].Equals("E"))
            {
                label3.Text = spaceShip[0];
                label4.Text = "ENEMIC!!";
                label4.ForeColor = Color.Red;
                //picture de la nau (video) --> Aixo diu el Pol que es molt fàcil i que ja ho fa ell
                pictureBox2.Visible = true;
                btn_laser.Visible = true;
                btn_misil.Visible = true;
                btn_Abort.Enabled = true;
                pictureBox3.ImageLocation = Application.StartupPath + "\\assets\\alert.png";
                //calcular un temps per apuntar i el gif es quedi fix
                //activar botons de disparar

            } else if (spaceShip[1].Equals("A"))
            {
                label3.Text = spaceShip[0];
                label4.Text = "Aliat";
                label4.ForeColor = Color.Green;
                //picture de la nau (video)
                btn_laser.Visible = false;
                btn_misil.Visible = false;
                btn_Abort.Enabled = false;
                //descarregar les armes
            }
            picture_SpaceShip.ImageLocation = Application.StartupPath + "\\assets\\models\\"+spaceShip[0]+".gif";
            picture_SpaceShip.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (slider1.Width < 1277)
            {
                slider1.Width += 100;
            }

            if (slider2.Width < 1277)
            {
                slider2.Width += 100;
            }

            if (slider1.Width >= 1277 && slider2.Width >= 1277)
            {
                btn_Start.Enabled = true;
                reloadWeapons.Stop();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            slider1.Width = 0;
            slider2.Width = 0;
            btn_Start.Enabled = false;
            btn_laser.Visible = false;
            btn_misil.Visible = false;
            picture_SpaceShip.Visible = false;
            reloadWeapons.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slider1.Width = 0;
            btn_laser.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slider2.Width = 0;
            btn_misil.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_laser.Visible = false;
            btn_misil.Visible = false;
            btn_Abort.Enabled = false;
            picture_SpaceShip.Visible = false;
            label3.Text = "";
            label4.Text = "";
            picture_SpaceShip.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            pictureBox3.ImageLocation = "";
            slider1.Width = 0;
            slider2.Width = 0;
            btn_Start.Enabled = false;
            if (reloadWeapons.Enabled) { reloadWeapons.Stop(); }
        }
    }
}
