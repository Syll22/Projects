using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int maxH = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < alphabet.Length; i++)
                dict.Add(alphabet[i], h[i]);

            for (int i = 0; i < word.Length - 1; i++)
                maxH = Math.Max(dict[word[i]], maxH);

            Console.WriteLine(maxH * word.Length);
        }
    }
}
