using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_1
{


    public class Khach
    {
        string ma, ten, dc;
        double tien;
        int tgg;
        bool hinhthuc;
        DateTime ngaygui;
        

        public Khach(string ma, string ten, string dc, double tien, int tgg, bool hinhthuc, DateTime ngaygui)
        {
            this.ma = ma;
            this.ten = ten;
            this.dc = dc;
            this.tien = tien;
            this.tgg = tgg;
            this.hinhthuc = hinhthuc;
            this.ngaygui = ngaygui;
        }

        public Khach() {
            hinhthuc=true;
        }

        public double tinhtien()
        {
            double s = 0, tyle = 0;
            if (tgg == 1) tyle = 0.06;
            if (tgg == 3) tyle = 0.07;
            if (tgg == 6) tyle = 0.08;
            if (tgg == 12) tyle = 0.09;
            if(hinhthuc == false)
            {
                tyle += 0.01;
            }
            s = tien*(1 + tyle * tgg / 12);
            return s;
        }

        public override string ToString()
        {
            string s = ma + " " + ten + " " + dc + " " + tien.ToString() + " " + tgg.ToString() + " thang ";
            if(hinhthuc == true)
            {
                s += " loai thuong ";
            }
            else
            {
                s += " loai phat loc ";
            }
            return s + ngaygui.ToString("dd/MM/yy") + " tong tien " + tinhtien().ToString();
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Dc { get => dc; set => dc = value; }
        public double Tien { get => tien; set => tien = value; }
        public int Tgg { get => tgg; set => tgg = value; }
        public bool Hinhthuc { get => hinhthuc; set => hinhthuc = value; }
        public DateTime Ngaygui { get => ngaygui; set => ngaygui = value; }
    }
}
