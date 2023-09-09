using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Sach
    {// fields
        string ma, ten, tg;
        int sl;

        public string ToSrting()
        {
            string s;
            s = ma + " " + ten + " " + tg;
            return s;
        }
        public Sach(string ma, string ten, string tg, int sl)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.Tg = tg;
            this.Sl = sl;
        }
        public Sach() { }

        public void input()
        {
            Console.Write("Nhap ma sach: ");
            ma = Console.ReadLine();
            Console.Write("Nhap ten sach: ");
            ten = Console.ReadLine();
            Console.Write("Nhap ten tac gia: ");
            tg = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            sl = int.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("Ma sach: " + ma);
            Console.WriteLine("Ten sach: " + ten);
            Console.WriteLine("Tac gia: " + tg);
            Console.WriteLine("So luong: " + sl.ToString());
        }




        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Tg { get => tg; set => tg = value; }
        public int Sl { get => sl; set => sl = value; }
    }


    public class Sach1:Sach
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

        new public string ToString()
        {
            string s;
            s = qrcode + " " + Ma + " " + Ten + " " + Tg + " " + Sl;
            return s;
        }

        public string Qrcode { get => qrcode; set => qrcode = value; }
    }
}
