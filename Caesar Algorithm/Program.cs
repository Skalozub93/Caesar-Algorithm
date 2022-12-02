using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Caesar_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to key for offset: ");     
            int k = int.Parse(Console.ReadLine());          

            Console.WriteLine("Enter to some text for encrypt: ");
            string text = Console.ReadLine();
            char[] message = text.ToCharArray();

            const string Alphabet = "ZYXWVUTSRQPONMLKJIHGFEDCBAabcdefghijklmnopqrstuvwxyz";
            char[] abcd = Alphabet.ToCharArray();

            int j; 
            int number;
            int key;

            for (int i = 0; i < message.Length; i++)
            {
                for (j = 0; j < abcd.Length; j++)
                {
                    if (message[i] == abcd[j])
                    {
                        break;
                    }
                }

                if (j != 52)
                {
                    number = j;

                    key = number + k;

                    if (key > 51)
                    {
                        key = key - 52;

                    }

                    message[i] = abcd[key];

                }
            }

            Console.WriteLine("Your encrypt text: ");
            Console.WriteLine(message);


           

           
        }      

    }

}
