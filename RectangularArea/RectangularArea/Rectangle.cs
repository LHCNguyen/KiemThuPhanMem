using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularArea
{
    public class Rectangle
    {
        private int cd, cr;
        public Rectangle (double cd, double cr)
        {
            this.cd = (int)cd;
            this.cr = (int)cr;
        }

        public double Cal(string Symbol)
        {
            double result = 0;
            switch(Symbol)
            {
                case "CV":
                    result = (this.cd + this.cr) * 2;
                    break;
                case "DT":
                    result = this.cd * this.cr;
                    break;
            }
            return result;
        }
    }
}
