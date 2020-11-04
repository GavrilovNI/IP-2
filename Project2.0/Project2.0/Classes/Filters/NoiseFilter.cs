using System;
using System.Collections.Generic;
using System.Text;
using IP1.Imaging.ColorNS;

namespace IP1.Imaging.Filters
{
    class NoiseFilter : PointFilter
    {
        public override ColorRGB RunColor(ColorRGB color)
        {
            byte r = 0, g = 0, b = 0;

            byte noisePower = 20;
            Random rnd = new Random();
            
            byte noise = Convert.ToByte((rnd.Next() + rnd.Next() + rnd.Next() + rnd.Next() - 2) * noisePower);
            return new ColorRGB(Convert.ToByte(r + noise), Convert.ToByte(g + noise), Convert.ToByte(b + noise));
        }
    }
}
