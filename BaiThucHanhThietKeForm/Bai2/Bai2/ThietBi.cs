using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(ThietBi tb)
        {

        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
