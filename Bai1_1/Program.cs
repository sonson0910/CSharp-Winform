using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_1
{
    class PTB2
    {
        double a, b, c;
        public void Nhap()
        {
            Console.WriteLine("CNTT3\nK62");
            double a, b, c, d;
            do
            {
                Console.Write("nhap a (a <> 0): ");
                a = double.Parse(Console.ReadLine());
            } while (a == 0);
            Console.Write("Nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c: ");
            bool k;
            k = double.TryParse(Console.ReadLine(), out c);
        }

        public void giai()
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("PTVN");
            }
            else
            {
                double x1, x2;
                x1 = (-b - Math.Sqrt(d)) / 2 * a;
                x2 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("x1 = {0},x2 = {1}", x1, x2);
            }
            Console.ReadLine();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
