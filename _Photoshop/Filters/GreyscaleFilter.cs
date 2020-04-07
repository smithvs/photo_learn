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
        public GreyscaleFilter() : base(new EmptyParameters()) { }
        public override string ToString()
        {
            return "Оттенки серого";
        }
        protected override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            return original.ToGrey();
        }
    }
}
