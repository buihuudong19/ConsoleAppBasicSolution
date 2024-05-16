using System;

namespace ConsoleAppStructuredProgramming
{
    class Program
    {
        /*
         *  Bài 0: Nhập vào từ bàn phím 1 số nguyên n và in ra tên bằng chữ của tháng đó.
            Bài 1: Viết chương trình C# tính tổng các số từ 1 đến n (1+2+3+..+n)
            Bài 2: Viết chương trình C# với hàm tính tổng dãy số: 1+1/3+1/5+..+1/(2*n+1)
         
         */

        //Bai tap thuc hanh voi mang 1 chieu (one-dimensional array)
        /*
          - Khai bao mang mot chieu
          - Them mot phan tu vao mang
          - Hien thi cac phan tu trong mang ra ngoai
          - update mot phan tu trong mang
          - Remove/Delete mot phan trong mang
 
         */

        static void Main(string[] args)
        {
            //Khai bao mang 1 chieu cac so nguyen
            int[] arrInt = new int[5]; //syntax C#
            int[] arrNumbers = { 1,3,5,7,5,10};
            PrintArray(arrNumbers);

            /*
            int[] result= AddInArray(arrNumbers, 10);
            Console.WriteLine("=========================");
            PrintArray(result);
            Console.WriteLine("=========================");
            AddInArray(ref arrNumbers, 11);
            PrintArray(result);
            Console.WriteLine("=========================");
            result = UpdateArray(arrNumbers, 20, -1);
            PrintArray(result);
              */
            Console.WriteLine("So phan tu mang sau khi xoa la: ");
            int[] result = DeleteArray(arrNumbers, 5);
            PrintArray(result);
          

            /*
            Console.Write("Hay nhap gia tri thang: ");
            int a = Convert.ToInt32(Console.ReadLine());
            PrintMonth(a);
            
            Console.Write("Nhap gia tri n = : ");
            int n = Convert.ToInt32(Console.ReadLine()); // "36" => 36; "36" + 1 ="361"
            Console.WriteLine($"Tong tu 1 den {n} la: {Sum(n)}");
            */
        }

        //ham xoa 1 phan tu trong mang

        static int[] DeleteArray(int[] numbers, int x)
        {
            //1 Tim vi tri ma lan dau tien x xuat hien trong mang numbers ==> p
            int p = -1;
            int[] temp;
            for(int i =0; i <numbers.Length; i++)
            {
                if (numbers[i] == x)
                {
                    p = i;
                    break;
                }
                   
            }
            if (p != -1) //tim thay
            {
                //2. "Xo" cac phan tu tu vi tri p+1 ve ben trai 1 phan tu
                for(int i = p; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                //3. Copy voi so luong phan tu giam di 1 sang mang moi va return 
                temp = new int[numbers.Length - 1];
                Array.Copy(numbers, 0, temp, 0, numbers.Length - 1);
                return temp;
            }

            return numbers;
        }

        //thay doi gia tri tai vi tri p nao do
        static int[] UpdateArray(int[] numbers, int x, int pos)
        {
            if (pos >= numbers.Length || pos < 0)
                return numbers; // neu pos ma invalid thi return mang ban dau

            numbers[pos] = x; //thay doi o vi tri pos voi gia tri x

            return numbers;
        }
        //them mot phan tu x vao trong mang 1 chieu

        static int[] AddInArray(int[] numbers, int x)
        {
            //dinh nghia mang gom length + 1 phan tu
            int[] temp = new int[numbers.Length + 1];
            // chuyen length phan tu tu numbers sang temp;
            for(int i = 0; i <numbers.Length; i++)
            {
                temp[i] = numbers[i];
            }
            //dua phan tu x vao vi tri length cua temp
           // temp[temp.Length-1] = x;
            temp[numbers.Length] = x;
            return temp;
        }

        //dung void, khong dung return
        static void AddInArray(ref int[] numbers, int x)
        {
            //dinh nghia mang gom length + 1 phan tu
            int[] temp = new int[numbers.Length + 1];
            // chuyen length phan tu tu numbers sang temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                temp[i] = numbers[i];
            }
            //dua phan tu x vao vi tri length cua temp
            // temp[temp.Length-1] = x;
            temp[numbers.Length] = x;
            numbers = temp;
        }




        //in cac phan tu trong mang
        static void PrintArray(int[] numbers)
        {
            int dem = 0;
            //cu phap 1:
            for(int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Phan tu thu {i + 1} la: {numbers[i]}");
            }
            Console.WriteLine("========================");
            // cu phap 2
            foreach(int n in numbers)
            {
                Console.WriteLine($"Phan tu thu {dem + 1} la: {n}");
                dem++;
            }
        }

        //Bài 0
        static void PrintMonth(int n)
        {
            int month = n;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Thang 1");
                    break;
                case 2:
                    Console.WriteLine("Thang 2");
                    break;
                case 3:
                    Console.WriteLine("Thang 3");
                    break;
                case 4:
                    Console.WriteLine("Thang 4");
                    break;
                case 5:
                    Console.WriteLine("Thang 5");
                    break;
                case 6:
                    Console.WriteLine("Thang 6");
                    break;
                case 7:
                    Console.WriteLine("Thang 7");
                    break;
                case 8:
                    Console.WriteLine("Thang 8");
                    break;
                case 9:
                    Console.WriteLine("Thang 9");
                    break;
                case 10:
                    Console.WriteLine("Thang 10");
                    break;
                case 11:
                    Console.WriteLine("Thang 11");
                    break;
                case 12:
                    Console.WriteLine("Thang 12");
                    break;
                default:
                    Console.WriteLine("Gia tri thang khong hop le");
                    break;
            }
        }

        //Bai 1: Signature
        static int Sum(int n)
        {
            int total = 0, i = 1;
            //while... do
            while (i <= n)
            {
                total += i; // total = total + i;
                i++; //i = i + 1;
            }
            return total;
        }
    }
}
