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

        string ruta = Application.StartupPath + "\\assets\\targets.txt";
        Random rnd = new Random();
        private void btn_Start_Click(object sender, EventArgs e)
        {
            List<String> lines = File.ReadLines(ruta).ToList();
            var lineCount = File.ReadLines(ruta).Count();

            
            int num = rnd.Next(0, lineCount-1);

            string[] adeu = lines[num].Split('|');

            if (adeu[1].Equals("E"))
            {
                //label de la nau
                //label del bandol
                //picture de la nau (video) --> Aixo diu el Pol que es molt fàcil i que ja ho fa ell
                //acitvar panel de apuntat
                //calcular un temps per apuntar i el gif es quedi fix
                //activar botons de disparar

            } else if (adeu[1].Equals("A"))
            {
                //label de la nau
                //label del bandol
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
                timer1.Stop();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            slider1.Width = 0;
            slider2.Width = 0;
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
    }
}
