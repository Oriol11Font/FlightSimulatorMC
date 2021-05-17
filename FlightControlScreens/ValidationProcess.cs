using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsMuchoCodigo;

namespace FlightControlScreen
{
    public partial class ValidationProcess : UserControl
    {
        public ValidationProcess()
        {
            InitializeComponent();
        }

        TPL tpl = new TPL();

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.lst.Items.Clear();
            progress1.Value = 0;
            progress2.Value = 0;
            progress3.Value = 0;
            progress4.Value = 0;
            progress5.Value = 0;
            progressG.Value = 0;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            Task t = Task.Run(() => { StartProcess(); });
        }

        private void StartProcess()
        {
            this.Invoke((MethodInvoker)delegate () { btn_Start.Enabled = false; });
            string[] uri = { "https://www.gutenberg.org/files/120/120-0.txt", "https://www.gutenberg.org/cache/epub/57303/pg57303.txt", "https://www.gutenberg.org/cache/epub/1228/pg1228.txt",
                "https://www.gutenberg.org/cache/epub/2000/pg2000.txt", "https://www.gutenberg.org/files/1524/1524-0.txt" };

            Parallel.Invoke(
                () =>
                {
                    WriteTextSafe("Starting process with: " + uri[0]);
                    DoChecks(tpl.CreateWordArray(uri[0]), lst, progress1);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        progressG.Value += 20;
                        label1.ForeColor = Color.Green;
                    });
                    WriteTextSafe("Finish process with: " + uri[0]);
                },
                () =>
                {
                    WriteTextSafe("Starting process with: " + uri[1]);
                    DoChecks(tpl.CreateWordArray(uri[1]), lst, progress2);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        progressG.Value += 20;
                        label2.ForeColor = Color.Green;
                    });
                    WriteTextSafe("Finish process with: " + uri[1]);
                },
                () =>
                {
                    WriteTextSafe("Starting process with: " + uri[2]);
                    DoChecks(tpl.CreateWordArray(uri[2]), lst, progress3);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        progressG.Value += 20;
                        label4.ForeColor = Color.Green;
                    });
                    WriteTextSafe("Finish process with: " + uri[2]);
                },
                () =>
                {
                    WriteTextSafe("Starting process with: " + uri[3]);
                    DoChecks(tpl.CreateWordArray(uri[3]), lst, progress4);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        progressG.Value += 20;
                        label3.ForeColor = Color.Green;
                    });
                    WriteTextSafe("Finish process with: " + uri[3]);
                },
                () =>
                {
                    WriteTextSafe("Starting process with: " + uri[4]);
                    DoChecks(tpl.CreateWordArray(uri[4]), lst, progress5);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        progressG.Value += 20;
                        label5.ForeColor = Color.Green;
                    });
                    WriteTextSafe("Finish process with: " + uri[4]);
                }
            );
            WriteTextSafe("INTEGRITY VERIFICATION SUCCESFULLY DONE!");
            this.Invoke((MethodInvoker)delegate () { btn_Start.Enabled = true; });
        }


        private void DoChecks(string[] words, ListBox lst, ProgressBar bar)
        {
            // aquí llençarem en paral·lel cadascuna de les tasques a fer en el Helper

            // Utilitzem aquests arrays per indicar quines paraules volem buscar i quina lletra 
            // Això serà necessari per alguns mètodes
            string[] Searchwords = { "white", "time", "that", "the", "empty", "door", "table" };
            string[] SearchLetter = { "A", "C", "W", "Z", "L", "S", "E" };

            Random rnd = new Random();     // servirà més tard per trobar a l'atzar la llargada d'algunes paraules

            Parallel.Invoke(
                () =>
                {
                    tpl.GetLongestWord(words);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        bar.Value += 10;
                    });
                },
                () =>
                {
                    tpl.GetMostCommonWords(words, rnd.Next(4, 10), 5);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        bar.Value += 10;
                    });
                },
                () =>
                {
                    tpl.GetMostCommonWordsByLength(words, rnd.Next(4, 10), 5);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        bar.Value += 10;
                    });
                },
                () =>
                {
                    foreach (string word in Searchwords)
                    {
                        tpl.GetCountForWord(words, word);
                    }
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        bar.Value += 10;
                    });
                },
                () =>
                {
                    foreach (string letter in SearchLetter)
                    {
                        tpl.GetCountForLetter(words, letter);
                    }
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        bar.Value += 10;
                    });
                },
                () =>
                {
                    tpl.GetLessCommonWords(words, rnd.Next(4, 10), 5);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        bar.Value += 10;
                    });
                }
            ); //close parallel.invoke
        }

        public delegate void SafeCallDelegate(string text);
        private void WriteTextSafe(string text)
        {
            if (lst.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                lst.Invoke(d, text);
            }
            else
            {
                lst.Items.Add(text);
            }
        }
    }
}
