using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsForm
{
    internal class TinhToan
    {
        public static void TongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }
        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i=1; i<n; i++)
            {
                tong += 1;
            }
            return tong;
        }
        

    }
}
