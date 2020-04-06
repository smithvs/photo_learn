using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Data
{
    public struct Pixel
    {
        double r;
        double g;
        double b;


        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = Check(value);
            }
        }

        public double G
        {
            get
            {
                return g;
            }
            set
            {
                g = Check(value);
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = Check(value);
            }
        }

        public Pixel(double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public static Pixel operator *(Pixel p, double num)
        {
            return new Pixel(
                Pixel.Trim(p.R * num),
                Pixel.Trim(p.G * num),
                Pixel.Trim(p.B * num));
        }

        public static Pixel operator *(double num, Pixel p)
        {
            return p*num;
        }

        double Check(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentException();
            return value;
        }

        public Pixel ToGrey()
        {
            double mean = (r + g + b) / 3;
            return new Pixel(mean, mean, mean);
        }

        public static double Trim(double value)
        {
            if (value < 0)
            {
                return 0;
            }
            if (value > 1)
            {
                return 1;
            }
            return value;
        }
    }
}
