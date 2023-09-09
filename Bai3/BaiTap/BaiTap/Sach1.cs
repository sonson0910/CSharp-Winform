using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Sach1:Sach
    {
        string qrcode;

        public Sach1()
        {
        }

        public Sach1(string qrcode, string ma, string ten, string tg, int sl):base(ma, ten, tg, sl)
        {
            this.qrcode = qrcode;
        }

        new public void input()
        {
            base.input();
            Console.Write("Nhap qrcode: ");
            qrcode = Console.ReadLine();
        }

        new public void output()
        {
            base.output();
            Console.WriteLine(" " +  qrcode);
        }

        public string Qrcode { get => qrcode; set => qrcode = value; }
    }
}
