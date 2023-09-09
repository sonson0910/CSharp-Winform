using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class UngDung
    {
        public List<Sach1> ls = new List<Sach1>();
        int n;
        public void nhap()
        {
            do
            {
                Console.WriteLine("Nhap so luong dau sach");
                n = int.Parse(Console.ReadLine());
            }while (n <= 0);
            for (int i = 0; i < n; i++)
            {
                Sach1 s = new Sach1();
                s.input();
                ls.Add(s);
            }
        }

        public void find(string qr)
        {
            bool k = true;
            foreach(Sach1 k1 in ls)
            {
                if (k1.Qrcode.Equals(qr))
                {
                    k1.output();
                    Console.WriteLine("Sach da ton tai trong kho");
                    k = true;
                }
                if (k == false)
                {
                    Console.WriteLine("Khong ton tai sach");
                }
            }
        }
    }


}
