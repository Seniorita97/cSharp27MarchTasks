using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string result = ReverseStr("Ali Memmed Ramin Mirqubad");
            //Console.WriteLine(result);



            //Console.WriteLine("Bir eded daxil edin");
            //int num;
            //bool number = int.TryParse(Console.ReadLine(), out num);

            //if (number)
            //{
            //    int reversedNumber = ReversedNum(num);
            //    Console.WriteLine(reversedNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //}


            //Console.WriteLine("Bir soz daxil edin");
            //string word = Console.ReadLine();
            //if (PlindromCheck(word))
            //{
            //    Console.WriteLine(true);
            //}
            //else { Console.WriteLine(false); }



            Console.WriteLine("Teksti daxil edin");
            string text = Console.ReadLine();
            CountTheLetter(text);
        }





        static void CountTheLetter(string text)
        {
            int[] counter = new int[26];
            foreach (char chr in text)
            {
                if (char.IsLetter(chr))
                {
                    int index = char.ToLower(chr) - 'a';
                    counter[index]++;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                char chr = (char)('a' + i);
                int count = counter[i];
                if (count > 0)
                {
                    Console.WriteLine($"'{chr}' herfi: {count} defe");
                }
            }
        }


        static bool PlindromCheck(string word)
        {
            string reverseWord = "";
            for (int i = word.Length-1; i >=0; i--)
            {
                reverseWord += word[i];
            }
            return word.ToUpper() == reverseWord.ToUpper();
        }



        static int ReversedNum(int num)
        {
            int reversedNumber = 0;
            while (num > 0) 
            {
                int lastDigit = num % 10;
                reversedNumber = (reversedNumber * 10) + lastDigit;
                num /= 10;
            }
            return reversedNumber;
        }



        static string ReverseStr(string text) 
        {

            string[] words = text.Split(' ');
            string result = "";
            foreach (string word in words) 
            {
                char[] chars = word.ToCharArray();
                Array.Reverse(chars);
                    result += new string(chars) + " ";

            }
            return result;
        }
    }
}
