using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Solution s1 = new Solution();
            Console.WriteLine(s1.LengthOfLastWord("Alaa Mohammed Amer"));
        }
    }
    public class Solution
    {
        public int LengthOfLastWord(string word)
        {
            int length = 0;
            bool Letterfounded = false;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] != ' ')
                {
                    Letterfounded = true;
                    length++;
                }
                if (Letterfounded && word[i - 1] == ' ')
                {
                    return length;
                }
            }
            return length;
        }
    }
}