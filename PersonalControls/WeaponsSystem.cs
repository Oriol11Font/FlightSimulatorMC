using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        bool dead = false;
        bool misil = false;
        bool laser = false;
        string[] spaceShip;
        Thread trd;
        
        private void btn_Start_Click(object sender, EventArgs e)
        {
            bool wait = true;

            pictureBox3.ImageLocation = "";

            trd = new Thread(SearchSpaceShips);
            trd.Start();

            while(wait)
            {
                if (!trd.IsAlive)
                {
                    if (spaceShip[1].Equals("E"))
                    {
                        label3.Text = spaceShip[0];
                        label4.Text = "ENEMIC!!";
                        label4.ForeColor = Color.Red;
                        aimPanel.Visible = true;
                        btn_Start.Enabled = false;
                        if (laser)
                        {
                            btn_laser.Visible = true;
                        }
                        if (misil)
                        {
                            btn_misil.Visible = true;
                        }

                        btn_Abort.Enabled = true;
                        pictureBox3.ImageLocation = Application.StartupPath + "\\assets\\alert.png";
                        aimPanel.ImageLocation = Application.StartupPath + "\\assets\\aimPanel.gif";
                        aimEnemy.Start();

                    }
                    else if (spaceShip[1].Equals("A"))
                    {
                        label3.Text = spaceShip[0];
                        label4.Text = "Aliat";
                        label4.ForeColor = Color.Green;
                        btn_laser.Visible = false;
                        btn_misil.Visible = false;
                        btn_Abort.Enabled = false;
                        label5.Visible = false;
                        aimPanel.Visible = false;
                        pictureBox3.ImageLocation = "";
                    }

                    picture_SpaceShip.ImageLocation = Application.StartupPath + "\\assets\\models\\" + spaceShip[0] + ".gif";
                    picture_SpaceShip.Visible = true;

                    wait = false;
                }
            }
        }


        private void SearchSpaceShips ()
        {
            List<string> lines = File.ReadLines(ruta).ToList();
            var lineCount = File.ReadLines(ruta).Count();

            int num = rnd.Next(0, lineCount - 1);

            spaceShip = lines[num].Split('|');

            trd.Abort();
        }

        private void reloadWeapons_Tick(object sender, EventArgs e)
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
                laser = true;
                misil = true;
                reloadWeapons.Stop();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            slider1.Width = 0;
            if (aimEnemy.Enabled) { aimEnemy.Stop(); }
            slider2.Width = 0;
            btn_Start.Enabled = false;
            btn_laser.Visible = false;
            btn_misil.Visible = false;
            label3.Text = "";
            label4.Text = "";
            pictureBox3.ImageLocation = "";
            label5.Visible = false;
            aimPanel.Visible = false;
            picture_SpaceShip.Visible = false;
            reloadWeapons.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slider1.Width = 0;
            laser = false;
            btn_laser.Visible = false;
            label5.Visible = false;
            if (dead)
            {
                btn_laser.Visible = false;
                btn_misil.Visible = false;
                btn_Abort.Enabled = false;
                btn_Start.Enabled = true;
                dead = false;
                aimPanel.ImageLocation = Application.StartupPath + "\\assets\\aimPanelFin.gif";
            }
            else
            {
                aimPanel.ImageLocation = Application.StartupPath + "\\assets\\aimPanel.gif";
                aimEnemy.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slider2.Width = 0;
            misil = false;
            btn_misil.Visible = false;
            label5.Visible = false;
            if (dead)
            {
                btn_laser.Visible = false;
                btn_misil.Visible = false;
                btn_Abort.Enabled = false;
                btn_Start.Enabled = true;
                dead = false;
                aimPanel.ImageLocation = Application.StartupPath + "\\assets\\aimPanelFin.gif";
            } else
            {
                aimPanel.ImageLocation = Application.StartupPath + "\\assets\\aimPanel.gif";
                aimEnemy.Start();
            }
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            btn_laser.Visible = false;
            btn_misil.Visible = false;
            btn_Abort.Enabled = false;
            picture_SpaceShip.Visible = false;
            label3.Text = "";
            label4.Text = "";
            label5.Visible = false;
            picture_SpaceShip.ImageLocation = "";
            aimPanel.ImageLocation = "";
            pictureBox3.ImageLocation = "";
            slider1.Width = 0;
            slider2.Width = 0;
            btn_Start.Enabled = false;
            if (reloadWeapons.Enabled) { reloadWeapons.Stop(); }
        }

        private void aimEnemy_Tick(object sender, EventArgs e)
        {
            aimPanel.ImageLocation = Application.StartupPath + "\\assets\\aimPanel.png";
            label5.Visible = true;
            dead = true;
            aimEnemy.Stop();
        }

        private void WeaponsSystem_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
