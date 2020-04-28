using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise001
{
    class Ellipse : Shape
    {
        private double Perimeter { get; set; }
        private double Area { get; set; }
        public Ellipse (double length, double width)
            {
                Lenght = length;
               Width = width;
                Area = Math.PI * Lenght * Width;
                Perimeter = Math.PI * (3 * (Lenght + Width) - Math.Sqrt((3 * Lenght + Width) * (Lenght + 3 * Width)));

            }  

        public override string ToString()
        {
            return string.Format("This is Ellipse :\nPerimeter = {0} \nArea = {1} ", Perimeter, Area);
        }



    }
}
