using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class shape
    {
        string color;
        bool filled;
        public shape() { }

        public shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }


    }

    class rectangle : shape
    {
        int w, h;
        public rectangle() { }

        public rectangle(int w, int h)
        {
            this.W = w;
            this.H = h;
        }

        public rectangle(int w, int h, string color, bool filled) : base(color, filled) {
            //shape(color, filled);
            this.W = w;
            this.H = h;
        }

        public int W { get => w; set => w = value; }
        public int H { get => h; set => h = value; }
    }

    class circle: shape
    {
        int x, y;
        double r;

        public circle() { }

        public circle(int x, int y, double r, string color, bool filled) : base(color, filled) {
            this.x = x;
            this.y = y;
            this.r = r;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
