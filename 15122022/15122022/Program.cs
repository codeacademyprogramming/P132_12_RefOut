using System;

namespace _15122022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;

            Console.WriteLine("Sayi daxil edin:");
            string countStr = Console.ReadLine();

            count = Convert.ToInt32(countStr);

            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Eded daxil edin:");
                string numStr = Console.ReadLine();

                numbers[i] = Convert.ToInt32(numStr);
            }

            Console.WriteLine("Ededler");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            string name = "   Sal   am           ";
            Console.WriteLine(name+" - "+name.Length);

            string newName = Trim(name);
            Console.WriteLine(name + " - " + name.Length);

        }

        static int FindFirstNonSpace(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }

            return -1;
        }

        static int FindLastNonSpace(string str)
        {
            for(int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                    return i;
            }
            return -1;
        }

        static string Trim(string str)
        {
            string newStr = "";

            for (int i = FindFirstNonSpace(str); i <= FindLastNonSpace(str); i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

      
    }
}
