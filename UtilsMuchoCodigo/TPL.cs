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
        public string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();

            //cerca la paraula més llarga del llibre

            string resultat = "Task 1 -- GetLongestWord in text is: " + longestWord;
            return resultat;

        }

        public string GetMostCommonWords(string[] words, int len, int quants)
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

            // cerca les paraules que apareixen més cops d'una determinada llargada i ens mostren quines són i quants cops apareixen
            // l'argument quants indica quantes paraules hem de mostrar Si indiquem 5 vol dir que mostrem les 5 que surten més
            // per defecte passem sempre 5
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir 
            // un nombre random entre 4 i 10 a la funció que fa la crida a aquesta

            return sb.ToString();
        }

        public string GetMostCommonWordsByLength(string[] words, int len, int quants)
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

            // cerca les paraules que apareixen més cops d'una determinada llargada i ens mostren quines són i quants cops apareixen
            // l'argument quants indica quantes paraules hem de mostrar Si indiquem 5 vol dir que mostrem les 5 que surten més
            // per defecte passem sempre 5
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir
            // un nombre random entre 4 i 10 a la funció que fa la crida a aquesta

            return sb.ToString();
        }

        public string GetCountForWord(string[] words, string term)
        {
            var findWord = from word in words
                           where word.ToUpper().Contains(term.ToUpper())
                           select word;

            // cerca quants cops apareix la paraula term en el llibre
            // l'argument term és cadascuna de les paraules que hi ha en l'array de paraules de DoChecks

            string resultat = "Task 4 -- GetCountForWord with word " + term + ": " + findWord.Count() + " times";
            return resultat;


        }

        public string GetCountForLetter(string[] words, string letter)
        {
            var findWord = from word in words
                           where word.ToUpper().StartsWith(letter.ToUpper())
                           select word;

            string resultat = "Task 5 -- GetCountForLetter with letter " + letter + ": " + findWord.Count() + " times";

            // cerca quants cops apareixen paraules que comencen amb la lletra indicada a l'argument letter 
            // l'argument letter és cadascuna de les lletres que hi ha en l'array de lletres de  DoChecks

            return resultat;
        }

        public string GetLessCommonWords(string[] words, int len, int quants)
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

            // cerca quants cops apareixen les paraules que menys apareixen i que tenen una determinada llargada
            // l'argument quants indica quantes paraules hem de mostrar. Si indiquem 5 vol dir que mostrem les 5 que surten menys
            // per defecte passem sempre 5 
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir 
            // un nombre random entre 4 i 10 a la funció que fa la crida a aquesta

            return sb.ToString();



        }
        public string[] CreateWordArray(string uri)
        {
            // Download a web page the easy way.
            string s = new WebClient().DownloadString(uri);

            return s.Split(
                new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
