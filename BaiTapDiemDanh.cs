
using System;

namespace BaiTapDiemDanh
{
    class ngay1005
    {
        public static void Main()
        {

            int[] arr1 = new int[10];
            int i, mx, mn, n;

            Console.Write("Nhap 10 so : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu {0}:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("So thu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("So lon nhat la: {0}\n", mx);
            Console.Write("So nho nhat la: {0}\n\n", mn);       

            Console.ReadKey();
        } 
    }
}