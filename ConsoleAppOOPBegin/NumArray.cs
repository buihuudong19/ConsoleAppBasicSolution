using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPBegin
{
    public class NumArray
    {
        //1 Khai báo các thuộc tính ---> tả đối tượng (dữ liệu)
        private int[] arrNums; //mảng chứa all số nguyên
        private int size; //Số lượng phần tử thực trong mảng arrNums
        //2. Hàm khởi tạo (Constructor)
        public NumArray()
        {
            arrNums = new int[2] {1,3}; //length = 2
            size = 2;
        }

        //3. Print 
        public void Print()
        {
            int dem = 0;
            foreach (int n in arrNums)
            {
                Console.WriteLine($"Phan tu thu {dem + 1} la: {n}");
                dem++;
            }
        }
        //4. Add
        public void Add(int x)
        {
            //logic add code
        }
        //5. Update
        public void Update(int x)
        {

        }
        //6. Delete
        public void Remove(int x)
        {

        }
        //6. return phan tu tai vi tri i
        public int GetByIndex(int i)
        {
            return arrNums[i];            
        }

    }
}
