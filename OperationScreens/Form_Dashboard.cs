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
            var trd = new Thread(formRun);
            trd.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            trd.Abort();
            Show();
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
                _ => null
            };

            if (form == null) return;

            if (form.AutoScroll)
                form.AutoScroll = false;
            
            pn_main.Controls.Clear();
            pn_main.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}