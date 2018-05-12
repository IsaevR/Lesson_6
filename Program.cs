using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CeasarEncription
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово,которое нужно зашифровать:");
            string s = Console.ReadLine();

            string abc = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЬЪЭЮЯ";

            int key = 3;

            List<string> result = new List<string>();
            
            
            result.Add(Ecription(s.ToUpper(), abc, key));
            

            foreach (var word in result)
            {
                Console.WriteLine("Зашифрованное слово:" + word.ToLower());
            }

            Console.ReadLine();


        }


        // метод которы шифрует строку способом сдвига каждого символа в право на три шага
        // он же называется Шифрованием Цезаря.
        static string Ecription(string targetWord, string abc, int key)
        {
            string result = string.Empty;
            for (int i = 0; i < targetWord.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (targetWord[i] == abc[j])
                    {
                        int temp = j + key;

                        while (temp >= abc.Length)
                            temp -= abc.Length;
                        result += abc[temp];
                    }
                }
            }
            return result;
        }
    }
    
}
