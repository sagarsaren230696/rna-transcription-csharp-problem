using System;
using System.Collections;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            char[] nucleotideChar = nucleotide.ToCharArray();
            Queue<char> rnaQueue = new Queue<char>();
            Dictionary<char,char> rnaTrans = new Dictionary<char, char>()
            {
                {'G','C'}, {'C','G'}, {'T','A'}, {'A','U'}
            };
            foreach(char c in nucleotideChar)
            {
                foreach(KeyValuePair<char,char> molecule in rnaTrans )
                {
                    if (c == molecule.Key)
                    {
                        rnaQueue.Enqueue(molecule.Value);
                    }
                }
            }
            char[] rnaChar = rnaQueue.ToArray();
            string rnaString = new string(rnaChar);
            return rnaString;
            throw new NotImplementedException("You need to implement this function.");
        }
        public static void Main(string[] args)
        {
            string nucleotide = Console.ReadLine();
            Console.WriteLine(ToRna(nucleotide));
        }
    }
}
