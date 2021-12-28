using System;

namespace Dna2Rna
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(dnaToRna(dna:""));
        }

        public static string dnaToRna(string dna)
        {
            // Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T')
            // Ribonucleic acid -> RNA
            // RNA differs slightly from DNA

            if (dna.Length != 0) return dna.Replace('T', 'U');
            else return "";
           
        }
    }
}
