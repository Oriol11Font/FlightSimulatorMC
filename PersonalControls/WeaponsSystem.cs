﻿using System;
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

            string[] adeu = lines[num].Split('|');

            if (adeu[1].Equals("E"))
            {
                label3.Text = adeu[0];
                label4.Text = "ENEMIC!!";
                label4.ForeColor = Color.Red;
                //picture de la nau (video) --> Aixo diu el Pol que es molt fàcil i que ja ho fa ell
                pictureBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                pictureBox3.ImageLocation = Application.StartupPath + "\\assets\\alert.png";
                //calcular un temps per apuntar i el gif es quedi fix
                //activar botons de disparar

            } else if (adeu[1].Equals("A"))
            {
                label3.Text = adeu[0];
                label4.Text = "Aliat";
                label4.ForeColor = Color.Green;
                //picture de la nau (video)
                //desactivar la opcio de disparar
                //descarregar les armes
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (slider1.Width < 1277)
            {
                slider1.Width += 50;
            }

            if (slider2.Width < 1277)
            {
                slider2.Width += 10;
            }

            if (slider1.Width >= 1277 && slider2.Width >= 1277)
            {
                btn_Start.Enabled = true;
                timer1.Stop();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            slider1.Width = 0;
            slider2.Width = 0;
            btn_Start.Enabled = false;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slider1.Width = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slider2.Width = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label3.Text = "";
            label4.Text = "";
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            pictureBox3.ImageLocation = "";
            slider1.Width = 0;
            slider2.Width = 0;
            btn_Start.Enabled = false;
            if (timer1.Enabled) { timer1.Stop(); }
        }
    }
}
