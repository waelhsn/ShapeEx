using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise001
{
    public abstract class Shape
    {
        public double _lenght;
        public  double _width;

        public double Area { get; }
        public double Lenght { get; set; }
        public double Perimeter
        {
            get { return _lenght; }
            set { _lenght = value; } 
        }
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
 


        public abstract override string ToString();


    }
}
