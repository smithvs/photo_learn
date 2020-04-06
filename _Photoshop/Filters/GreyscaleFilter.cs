using MyPhotoshop.Data;
using MyPhotoshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class GreyscaleFilter : PixelFilter
    {
        public override ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }

        public override string ToString()
        {
            return "Оттенки серого";
        }
        protected override Pixel ProcessPixel(Pixel original, double[] parameters)
        {
            return original.ToGrey();
        }
    }
}
