using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("----------HomeWork_1----------");
            int n;
            Console.Write("Введите размер массива: ");n=Convert.ToInt32(Console.ReadLine());
            var arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=rnd.Next(10);
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            // Console.WriteLine("----------Min----------");
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min=arr[i];
                }
            }
            Console.WriteLine($"min = {min}");
            // Console.WriteLine("----------Max----------");
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max=arr[i];
                }
            }
            Console.WriteLine($"max = {max}");
            // Console.WriteLine("----------Sum----------");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum+=arr[i];
            }
            Console.WriteLine($"sum = {sum}");
            // Console.WriteLine("-----Arthmetic_Mean----");
            double arifm,sum_1;
            sum_1=Convert.ToDouble(sum);
            arifm = sum_1 / arr.Length;
            System.Console.WriteLine($"Arifm = {arifm}");
            // Console.WriteLine("------Odd_Numbers------");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==1)
                {
                    Console.Write(arr[i]+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------HomeWork_2----------");
            int m;
            Console.Write("Введите размер массива: ");m=Convert.ToInt32(Console.ReadLine());
            var arr_1 = new int[m];
            for (int i = 0; i < arr_1.Length; i++)
            {
                arr_1[i]=rnd.Next(10);
                Console.Write(arr_1[i]+" ");
            }
            Console.WriteLine();
            for (int i = arr_1.Length-1; i >= 0; i--)
            {
                Console.Write(arr_1[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("----------HomeWork_3----------");
            int N;
            Console.Write("Введите размер массива: "); N = Convert.ToInt32(Console.ReadLine());
            var rndNumbers = new int[N];
            for (int i = 0; i < rndNumbers.Length; i++)
            {
                rndNumbers[i] = rnd.Next(10);
                Console.Write(rndNumbers[i] + " ");
            }
            Console.WriteLine();
            Console.Write("count = ");int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("index = ");int index = Convert.ToInt32(Console.ReadLine());
            var newRndNumbers = new int[count];
            for (int i = 0; i < newRndNumbers.Length; i++)
            {
                if((index + i) < N)
                {
                    newRndNumbers[i] = rndNumbers[index + i];
                    Console.Write($"{newRndNumbers[i]}  ");
                }
                else
                {
                    newRndNumbers[i] = 1;
                    Console.Write($"{newRndNumbers[i]}  ");
                }
            }


        }
    }
}
