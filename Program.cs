using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace giatrinhonhatbangphuongthuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {9999, 4, 10, 5,  6,20, 999,1000 };
            int index = Minvalue(array);

            Console.WriteLine("gia tri nho nhat tai vi tri index = " + array[index] + " tai " +index);

        }
        public static int Minvalue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
