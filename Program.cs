using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "▀ тїюфшы тьхёЄю фшъюую чтхЁ т ъыхЄъє,";
            byte[] bytes = Encoding.GetEncoding(866).GetBytes(str);
            string newStr = Encoding.GetEncoding(1251).GetString(bytes);
            Console.WriteLine(newStr);
            char[] alphabet = {'_','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','m','n','o','p','q','r','s','t','u', 'v','w','x','y','z'};
            Console.WriteLine("***ШИФРОВКА ЦЕЗАРЯ***");
            Console.WriteLine("Введите сообщение");
            string message = Console.ReadLine();
            int key=-1;
            while (key < 0 || key > 26)
            {
                Console.WriteLine("Введите ключ");
                key = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Результат");
            string output= "";
            foreach(char a in message)
            {
                int index=0;
                for (int i = 0; i < alphabet.Length; i++)
                {
                if(alphabet[i].Equals(a))
                {
                        index = i + key;
                        if (index > 26)
                            index = index - 26;
                }
                }
                output += alphabet[index];
            }
            Console.WriteLine(output);
            Console.WriteLine("***ЦЕЗАРЬ. ДЕКОДИРОВКА***");
            Console.WriteLine("Введите зашифрованное сообщение");
            string str1 = Console.ReadLine();
            for (int i = 1; i < 27; i++)
            {
                string outputt = "";
                foreach (char a in str1)
                {

                    int index = 0;
                    for (int s = 0; s < alphabet.Length; s++)
                    {
                        if (alphabet[s].Equals(a))
                        {
                            index = s + i;
                            if (index > 26)
                                index = index - 26;
                        }
                    }
                    outputt += alphabet[index];
                }
                Console.WriteLine($"Ключ: {i}.     Строка: {outputt}");
            }


        }
    }
}
