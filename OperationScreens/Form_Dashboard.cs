using System;
using System.Threading;
using System.Windows.Forms;
using PersonalControls;

namespace OperationScreens
{
    public partial class Form_dashboard : Form
    {
        public Form_dashboard()
        {
            InitializeComponent();
        }

        private static void formRun ()
        {
            Application.Run(new Form_Splash());
        }

        private void HandleFormChange(object sender, EventArgs e)
        {
            if (sender is not Button button) return;

            var btnName = button.Name;

            dynamic form = btnName switch
            {
                "button1" => new ValidationProcess(),
                "button2" => new SelectionPlanet(),
                "button3" => new SpaceShipDetails(),
                "button5" => new WeaponsSystem(),
                _ => null
            };
            
            pn_main.Controls.Clear();

            if (form == null) return;

            if (form.AutoScroll)
                form.AutoScroll = false;
            
            pn_main.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}