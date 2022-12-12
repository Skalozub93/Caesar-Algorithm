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
            Console.WriteLine("Input integer key for offset: ");     
            int inputKey = int.Parse(Console.ReadLine());   
            
            if(inputKey < -51 || inputKey > 51)
            {
                throw new Exception("Incorrect key number!!!");
            }

            Console.WriteLine("Input to some text:");
            string inputText = Console.ReadLine();
   

            Console.WriteLine("Select the operation:" +
                "1 - Encrypt, 0 - Decrypt");
            int operation = int.Parse(Console.ReadLine());
            if (operation == 0)
            {
                Console.WriteLine(Encrypt(inputText, inputKey));
            }
            else if(operation == 1)
            {
                Console.WriteLine(Decrypt(inputText, inputKey));
            }
            else
            {
                throw new Exception("Error!");
            }

        }      

        static public string Encrypt(string text, int key)
        {
            const string Alphabet = "ZYXWVUTSRQPONMLKJIHGFEDCBAabcdefghijklmnopqrstuvwxyz";
            char[] abcd = Alphabet.ToCharArray();

            char[] message = text.ToCharArray();

            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < abcd.Length; j++)
                {
                    if (text[i] == abcd[j])
                    {
                        result += message[i] = abcd[(j + key) % 52];
                        break;
                    }
                }
            }

            return result;
        }

        static public string Decrypt(string text, int key)
        {

            const string Alphabet = "ZYXWVUTSRQPONMLKJIHGFEDCBAabcdefghijklmnopqrstuvwxyz";
            char[] abcd = Alphabet.ToCharArray();

            char[] message = text.ToCharArray();

            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < abcd.Length; j++)
                {
                    if (text[i] == abcd[j])
                    {
                        result += message[i] = abcd[(j - key) % 52];
                        break;
                    }
                }
            }
            
            return result;
        }

        
    }

    

}
