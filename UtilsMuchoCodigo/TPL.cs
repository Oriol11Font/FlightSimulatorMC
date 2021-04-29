using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UtilsMuchoCodigo
{
    public class TPL
    {
        private void StartProcess()
        {
            string[] nomFitxer = { "1.txt", "2.txt", "3.txt" };

            //Per a cada fitxer cal fer una crida en paral·lel a la funció DoChecks passant a part de 
            // l'array de strings també el control on volem pintar els resultats
            Parallel.Invoke(
                () =>
                {
                    /*lstData0.Items.Add("File 1 - Starting process...");
                    DoChecks(CreateWordArray(nomFitxer[0]), lstData0);
                    lstData0.Items.Add("File 1 - Process complete!");
                    lstData0.BackColor = System.Drawing.Color.Green;*/
                },
                () =>
                {
                    /*lstData1.Items.Add("File 2 - Starting process...");
                    DoChecks(CreateWordArray(nomFitxer[1]), lstData1);
                    lstData1.Items.Add("File 2 - Process complete!");
                    lstData1.BackColor = System.Drawing.Color.Green; */
                },
                () =>
                {
                    /*lstData2.Items.Add("File 3 - Starting process...");
                    DoChecks(CreateWordArray(nomFitxer[2]), lstData2);
                    lstData2.Items.Add("File 3 - Process complete!");
                    lstData2.BackColor = System.Drawing.Color.Green; */
                }
            );
        }

        private void DoChecks(string[] words, List<String> lst)
        {
            string[] Searchwords = { "white", "time", "that", "the", "empty", "door", "table" };
            string[] SearchLetter = { "A", "C", "W", "Z", "L", "S", "E" };

            Random rnd = new Random();

            Parallel.Invoke(
                () =>
                {
                    lst.Add("Task 1 -- Starting GetLongestWord...");
                    lst.Add(GetLongestWord(words));
                },
                () =>
                {
                    lst.Add("Task 2 -- Starting GetMostCommonWords...");
                    lst.Add(GetMostCommonWords(words, rnd.Next(4, 10), 5));
                },
                () =>
                {
                    lst.Add("Task 3 -- Starting GetMostCommonWordsByLength...");
                    lst.Add(GetMostCommonWordsByLength(words, rnd.Next(4, 10), 5));
                },
                () =>
                {
                    lst.Add("Task 4 -- Starting GetCountForWord...");
                    foreach (string word in Searchwords)
                    {
                        lst.Add(GetCountForWord(words, word));
                    }
                },
                () =>
                {
                    lst.Add("Task 5 -- Starting GetCountForLetter...");
                    foreach (string letter in SearchLetter)
                    {
                        lst.Add(GetCountForLetter(words, letter));
                    }

                },
                () =>
                {
                    lst.Add("Task 6 -- Starting GetLessCommonWords...");
                    lst.Add(GetLessCommonWords(words, rnd.Next(4, 10), 5));
                }
            ); //close parallel.invoke
        }


        #region HelperMethods


        private string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();

            string resultat = "Task 1 -- GetLongestWord in text is: " + longestWord;
            return resultat;

        }

        private string GetMostCommonWords(string[] words, int len, int quants)
        {
            var frequencyOrder = from word in words
                                 where word.Length > len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 2 -- GetMostCommonWords with length more than " + len + " are:");
            foreach (var v in commonWords)
            {
                var findWord = from word in words
                               where word.ToUpper().Contains(v.ToUpper())
                               select word;

                sb.AppendLine("  " + v + " - with " + findWord.Count() + " times //");
            }

            return sb.ToString();
        }

        private string GetMostCommonWordsByLength(string[] words, int len, int quants)
        {
            var frequencyOrder = from word in words
                                 where word.Length == len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 3 -- GetMostCommonWordsByLength with length " + len + " are:");
            foreach (var v in commonWords)
            {
                var findWord = from word in words
                               where word.ToUpper().Contains(v.ToUpper())
                               select word;

                sb.AppendLine("  " + v + " - with " + findWord.Count() + " times //");
            }

            return sb.ToString();
        }

        private string GetCountForWord(string[] words, string term)
        {
            var findWord = from word in words
                           where word.ToUpper().Contains(term.ToUpper())
                           select word;

            string resultat = "Task 4 -- GetCountForWord with word " + term + ": " + findWord.Count() + " times";
            return resultat;


        }

        private string GetCountForLetter(string[] words, string letter)
        {
            var findWord = from word in words
                           where word.ToUpper().StartsWith(letter.ToUpper())
                           select word;

            string resultat = "Task 5 -- GetCountForLetter with letter " + letter + ": " + findWord.Count() + " times";

            return resultat;
        }

        private string GetLessCommonWords(string[] words, int len, int quants)
        {
            var frequencyOrder = from word in words
                                 where word.Length > len
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 6 -- GetLessCommonWords with length more than " + len + " are:");
            foreach (var v in commonWords)
            {
                var findWord = from word in words
                               where word.ToUpper().Contains(v.ToUpper())
                               select word;

                sb.AppendLine("  " + v + " - with " + findWord.Count() + " times //");
            }

            return sb.ToString();
        }

        private string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieving from {uri}");

            // Download a web page the easy way.
            string s = new WebClient().DownloadString(uri);

            return s.Split(
                new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }

        #endregion
    }
}
