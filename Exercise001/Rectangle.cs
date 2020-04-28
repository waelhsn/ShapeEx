using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise001
{
    class Rectangle : Shape
    {
        public new double Perimeter { get; set; }
        public new double Area { get; set; }

        public Rectangle()
        {
        }
        public Rectangle(double _lenght, double _widht)
        {
            Lenght = _lenght;
            Width = _widht;
            Perimeter = 2 * (Lenght + Width);
            Area = Lenght * Width;
        }
        public override string ToString()
        {
            return string.Format("This is Rectangle :\nPerimeter = {0}\nArea = {1} ", Perimeter, Area);
        }
    }

}
