using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 25;

            Sqrt(ref num);

            Console.WriteLine(num);

            string str = "salam,   necesen ?";
            ChangeSpace(ref str);
            Console.WriteLine(str);//salam,---necesen-?

            int[] nums = { 3, 478, 4 };
            IncreaseArr(ref nums);


            //{3,478,4,0}
        }

        //Verilmis ededi kvadratina ceviren metod
        static void Sqrt(ref int x)
        {
            x *= x ;
        }

        //Verilmis stringdeki butun bosluqlari '-' ile deyisen metod
        static void ChangeSpace(ref string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                    newStr += '-';
                else
                    newStr += str[i];
            }

            str = newStr;
        }


        //Verilmis int arrayinin uzunlugunu 1 vahid artiran metod
        static void IncreaseArr(ref int[] arr)
        {
            int[] newArr = new int[arr.Length + 1];


            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }

    }
}
