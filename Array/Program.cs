using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        int[] numbers;
        Program()
        {
            int size = 0;
            Console.WriteLine("plz enter size");
            size = Convert.ToInt32(Console.ReadLine());
            numbers = new int[size];

        }

        void TakeNumber()
        {
            for (int i = 0; i <= numbers.Length; i++)
            {
                Console.WriteLine("plz enter the number{0}", (i + 1));

                while (!Int32.TryParse(Console.ReadLine(), out numbers[i])) 
                {
                    Console.WriteLine("invalid num");
                }

            }
        }
        void print()
        {
            // for (int i = 0; i < size; i++)
            //{
            //  console.writeline(numbers[i]);
            //}
            Console.WriteLine("the no are");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        void SortArray()
        { int temp = 0;
            for (int i=0;i<numbers.Length;i++)
            {
                for(int j=0;j<numbers.Length-1;j++)
                {
                    if(numbers[j]>numbers[j+1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SortArray();
            p.TakeNumber();
            p.print();
            Console.ReadKey();
        }
    }
}
