using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_1
{
    class CauA
    {
        public CauA() { }
        int[] ints;
        int n;
        public void input()
        {
            Console.Write("Nhap so phan tu cua day: ");
            this.n = int.Parse(Console.ReadLine());
            this.ints = new int[n];
            for(int i = 0; i < this.n; i++)
            {
                Console.Write("Phan tu " + i + ": ");
                this.ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        public int[] sort(int[] ints)
        {
            int i, key, j;
            for(i = 1; i < ints.Length; i++)
            {
                key = ints[i];
                j = i - 1;
                while(j >= 0 && ints[j] > key)
                {
                    ints[i + 1] = ints[j];
                    --j;
                }
                ints[j + 1] = key;
            }
            return ints;
        }

        public void Output()
        {
            Console.Write("Cac phan tu trong day: ");
            foreach(int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            this.ints = sort(ints);
            Console.Write("Day sau khi duoc sap xep: ");
            foreach(int i in ints)
            {
                Console.Write(i + " ");
            }
        }
    }

    class CauB
    {
        public CauB() { }
        int numerator, denominator;
        public void input()
        {
            Console.Write(" numerator: ");
            this.numerator = int.Parse(Console.ReadLine());
            do
            {
                Console.Write(" denominator: ");
                this.denominator = int.Parse(Console.ReadLine());
            } while (this.denominator == 0);
        }

        public double sum(CauB x)
        {
            return (double)(this.numerator * x.denominator + this.denominator * x.numerator) / (this.denominator * x.denominator);
        }

        public double difference(CauB x)
        {
            return (double)(this.numerator * x.denominator - this.denominator * x.numerator) / (this.denominator * x.denominator);
        }

        public double product(CauB x)
        {
            return (double)(this.numerator * x.numerator) / (x.denominator * this.denominator);
        }

        public double quotient(CauB x)
        {
            return (double)(this.numerator * x.denominator) / (this.denominator * x.numerator);
        }

        public void output()
        {
            Console.WriteLine(this.numerator + " / " + this.denominator);
        }
    }

    class CauC
    {
        public CauC() { }
        double[] arr;
        int n;
        public void input()
        {
            Console.Write("Nhap vao so phan tu co trong day: ");
            this.n = int.Parse(Console.ReadLine());
            this.arr = new double[n];
            for (int i = 0; i < this.n; i++)
            {
                Console.Write("Nhap so thuc " + i + ": ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        public double doubleMax()
        {
            double max = -int.MaxValue;
            foreach(double i in arr)
            {
                if(i > max) max = i;
            }
            return max;
        }

        public double sum() {
            double s = 0;
            foreach(double i in arr)
            {
                s += i;
            }
            return s;
        }

        public int countNegative() {
            int count = 0;
            foreach(int i in arr)
            {
                if (i < 0) ++count;
            }
            return count;
        }

        public void output() {
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    class CauD
    {
        string msv, name, birth, addr;
        double t, l, h, tb;
        public CauD() { }

        public CauD(int n, string msv, string name, string birth, string addr, double t, double l, double h, double tb)
        {
            this.msv = msv;
            this.name = name;
            this.birth = birth;
            this.addr = addr;
            this.t = t;
            this.l = l;
            this.h = h;
            this.tb = tb;
        }

        public void input()
        {
            Console.Write("Nhap ma sinh vien: ");
            this.msv = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            this.name = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            this.birth = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            this.addr = Console.ReadLine();
            Console.Write("Nhap diem mon toan: ");
            this.t = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon ly: ");
            this.l = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon hoa: ");
            this.h = double.Parse(Console.ReadLine());
        }

        public double dtb()
        {
            this.tb = (double)(this.t + this.l + this.h) / 3;
            return this.tb;
        }

        public void output() {
            Console.WriteLine("Ma sinh vien: " + this.msv);
            Console.WriteLine("Ho va ten: " + this.name);
            Console.WriteLine("Ngay sinh: " + this.birth);
            Console.WriteLine("Que quan: " + this.addr);
            Console.WriteLine("Diem mon toan: " + this.t);
            Console.WriteLine("Diem mon ly: " + this.l);
            Console.WriteLine("Diem mon hoa: " + this.h);
            Console.WriteLine("Diem trung binh 3 mon: " + this.dtb());
        }

        public string getMSV()
        {
            return this.msv;
        }

        public double getDtb()
        {
            return this.tb;
        }
    }


    internal class Program
    {
        public void CauA()
        {
            CauA a = new CauA();
            a.input();
            a.Output();
        }

        public void CauB()
        {
            CauB fraction1 = new CauB();
            CauB fraction2 = new CauB();
            Console.WriteLine("enter fraction 1: ");
            fraction1.input();
            Console.WriteLine("enter fraction 2: ");
            fraction2.input();

            Console.Write("fraction 1: ");
            fraction1.output();
            Console.WriteLine();
            Console.Write("fraction 2: ");
            fraction2.output();
            Console.WriteLine();

            Console.WriteLine("Sum 2 fraction = " + fraction1.sum(fraction2));
            Console.WriteLine("Difference 2 fraction = " + fraction1.difference(fraction2));
            Console.WriteLine("Quotient 2 fraction = " + fraction1.quotient(fraction2));
            Console.WriteLine("Product 2 fraction = " + fraction1.product(fraction2));
        }

        public void CauC()
        {
            CauC c = new CauC();
            c.input();
            Console.WriteLine("Day so hien tai: ");
            c.output();
            Console.WriteLine("So lon nhat trong day = " + c.doubleMax());

            Console.WriteLine("Tong cua day = " + c.sum());
            
            Console.WriteLine("So phan tu am = " + c.countNegative());
        }

        public void CauD()
        {
            int n;
            CauD[] sv;
            /* Ý 1 */
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            sv = new CauD[n];
            Console.WriteLine("Nhap thong tin cac sinh vien: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien " + (i + 1) + ": ");
                sv[i] = new CauD();
                sv[i].input();
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();

            /* Ý 2 */
            Console.WriteLine("Danh sach cac sinh vien dang quan ly: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien " + (i + 1) + ": ");
                sv[i].output();
            }

            int tmp = -1;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            /* Ý 3 */
            do
            {
                Console.Write("Nhap ma sinh vien de tim kiem thong tin: ");
                String msv = Console.ReadLine();
                foreach(CauD svi in sv)
                {
                    if (svi.getMSV().Equals(msv))
                    {
                        svi.output();
                    }
                }
                Console.Write("Nhap phim 1 neu ban chon tim kiem tiep, nguoc lai la 0: ");
                tmp = int.Parse(Console.ReadLine());
            }while(tmp == 1);

            /* Ý 4 */
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Danh sach cac sinh vien co diem trung binh > 7.0: ");
            foreach (CauD svi in sv)
            {
                if (svi.getDtb() > 7.0)
                {
                    svi.output();
                }
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Program solve = new Program();
            // Cau a
            solve.CauA();
            
            // Cau b
            solve.CauB();

            // Cau c
            solve.CauC();

            // Cau d
            solve.CauD();

            Console.ReadLine();
        }
    }
}
