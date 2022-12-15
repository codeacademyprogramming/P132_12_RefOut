using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { -4, 4, 5, -10, 22 };
            var newNumbers = MakePositive(numbers);

            for (int i = 0; i < newNumbers.Length; i++)
            {
                Console.WriteLine(newNumbers[i]);
            }

            Console.WriteLine("============Lesson============");

            int age = 60;
            
            SetZero(out age); //SetZero(60);
            Console.WriteLine("Age: "+age);

            string text = "Hello";
            SetBye(out text);

            Console.WriteLine("Text:"+ text);

            int[] nums = { 45, 10, 4 };
            SetZero(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            string name = "   salam   ";
            Trim(ref name);

            Console.WriteLine(name);

            //Char methods

            char letter = 'A';

            var newLetter = char.ToLower(letter);

            //Char methods

            Console.WriteLine(Char.IsDigit('4'));
            Console.WriteLine(Char.ToUpper('d'));
            Console.WriteLine(Char.IsUpper('D'));
            Console.WriteLine(Char.IsLetter('D'));
            Console.WriteLine(Char.IsLetterOrDigit('4'));


            //int methods
            int num = 43;
            num = int.Parse("4");

            //string methods
            string str = "  Hello Worl d!   ";


            var newStr = str.Substring(6,2);
            Console.WriteLine(str.IndexOf(' '));
            Console.WriteLine(str.IndexOf("Hello"));
            Console.WriteLine(str.LastIndexOf(' '));
            Console.WriteLine(str.Replace(" ",""));
            Console.WriteLine(str.Trim());

            string sentence = "salam necesen?";
            Console.WriteLine(sentence.StartsWith("salam n"));
            Console.WriteLine(sentence.StartsWith(" salam"));
            Console.WriteLine(sentence.EndsWith(" necesen?"));

            sentence = "salam,sagol,necesen"; 

            var wordsArr = sentence.Split(',');

            var newSentence = string.Join(" ", wordsArr);

            if (newSentence == null || newSentence=="") //string.IsNullOrEmpty(newSentence)
            {

            }

            if (string.IsNullOrWhiteSpace(newSentence))
            {

            }

            Console.WriteLine(newSentence);

            int[] arr = { 4, 5, 6 ,4};

            Array.IndexOf(arr, 4); //0
            Array.LastIndexOf(arr, 4); //3
        }

        //Verilmis ededler siyahisindaki butun ededleri musbet sekilde qaytaran metod
        // {34, -45,-2,5} -> {34, 45, 2, 5}

        static int[] MakePositive(int[] nums)
        {
            int[] newNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] < 0)
                    newNums[i] = nums[i] * -1;
                else
                    newNums[i] = nums[i];

            }

            return newNums;
        }

        static void SetZero(out int n)
        {
            n = 0;
        }

        static void SetBye(out string str)
        {
            str = "Bye";
        }

        static void SetZero(int[] nums)
        {
            for (int i = 0;i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        static int FindFirstNonSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }

            return -1;
        }

        static int FindLastNonSpace(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                    return i;
            }
            return -1;
        }

        static void Trim(ref string str)
        {
            string newStr = "";

            for (int i = FindFirstNonSpace(str); i <= FindLastNonSpace(str); i++)
            {
                newStr += str[i];
            }

            str = newStr;
        }

    }
}
