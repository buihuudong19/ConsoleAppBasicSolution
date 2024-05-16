using System;

namespace ConsoleAppBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //single line
            /*
              --- dong 1
              --- dong 2
             */

            /*
             * data types:
             * 
             */

            int age = 10;
            double salary = 100_000;
            string name = "Bui Huu Dong";
            string address = "Quan 10";
            bool isCheck = false;
            char manager = 'A';
            string result = $"{name} has age {age} and address is: {address}";

            int a = 11;


            /*
              Viết chương trình nhập vào một điểm và in ra hạnh kiểm:
                - Nếu điểm >0 và <5      => Hạnh kiểm yếu
                - Nếu điểm >=5 và <=6    => Hạnh kiểm trung bình
                - Nếu điểm >6 và <= 7    => Hạnh kiểm khá
                - Nếu điểm >7            => Hạnh kiểm tốt 
             */
            //call function
            Console.Write("Enter a number: ");
            double b = Convert.ToDouble(Console.ReadLine()); //10.0
            PrintGrade(b);

            int n = 10, m = 11;
        
            Console.Write($"Tong gia tri cua {m} va {n} la: {Add(n,m)}");

            Console.ReadLine();
        }

        //Hàm in hạnh kiểm
        static void PrintGrade(double d)
        {
            if (d <= 0) return;

            if(d > 0 && d <= 5)
            {
                Console.WriteLine("Hạnh kiểm yếu!");
            }else if(d>=5 && d <= 6)
            {
                Console.WriteLine("Hạnh kiểm TB!");
            }else if(d>6 && d<=7)
            {
                Console.WriteLine("Hạnh kiểm Kha!");
            }
            else
            {
                Console.WriteLine("Hạnh kiểm Tot!");
            }

        }

        //Tinh toan ve tong hai so
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
