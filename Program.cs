using System;
namespace bttl1
{
    class SanPham
    {
        internal string masp;
        internal string tensp;
        internal double gia;
        internal int tonkho;
        public SanPham(string masp, string tensp, double gia, int tonkho)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.gia = gia;
            this.tonkho = tonkho;
        }
        public override string ToString()
        {
            return masp + " " + tensp + " " + gia + " " + tonkho;
        }
    }
    class Program
    {
        static LinkedList<SanPham> sanphams = new LinkedList<SanPham>();
        static void XuatList(LinkedList<SanPham> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void TimKiem(SanPham sanpham)
        {
            int count = 0;
            foreach (var item in sanphams)
            {
                if (item.masp == sanpham.masp)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine("Tim kiem thanh cong");
                Console.WriteLine(sanpham);
            }
            else
            {
                Console.WriteLine("Tim kiem that bai");
            }
        }
        static void ThemSp(ref SanPham sanpham)
        {
            int count = 0;
            foreach (var item in sanphams)
            {
                if (item.masp == (sanpham).masp)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                sanphams.AddLast(sanpham);
                Console.WriteLine("Them san pham thanh cong");
            }
            else
            {
                Console.WriteLine("San pham da ton tai");
            }
        }
        static void XoaSp(ref SanPham sanpham)
        {
            int count = 0;
            foreach (var item in sanphams)
            {
                if (item.masp == (sanpham).masp)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                sanphams.Remove(sanpham);
                Console.WriteLine("Da xoa san pham thanh cong");
            }
            else
            {
                Console.WriteLine("Xoa san pham that bai");
            }
        }
        public static void Main()
        {
            SanPham keo = new SanPham("sp1", "Keo", 2000, 100);
            SanPham banh = new SanPham("sp2", "Banh", 5000, 50);
            SanPham sua = new SanPham("sp3", "Sua", 10000, 20);
            sanphams.AddLast(keo);
            sanphams.AddLast(banh);
            sanphams.AddLast(sua);
            TimKiem(banh);
            SanPham nuoc = new SanPham("sp4", "coca", 10000, 30);
            ThemSp(ref nuoc);
            XoaSp(ref keo);
            XuatList(sanphams);
        }
    }
}