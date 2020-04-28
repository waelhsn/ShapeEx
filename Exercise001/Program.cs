using System;

namespace Exercise001
{
    class Program
    {
        private double width;
        private double length;

        public enum ShapeType
        {
            Ellipse,
            Rectangle
        }
        public Shape CreateShape(ShapeType shape)
        {

            switch (shape)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(length, width);
                case ShapeType.Rectangle:
                    return new Rectangle();
                default:
                    return null;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Shape[] arrayofShapes = new Shape[2];
                arrayofShapes[0] = new Rectangle(15, 25);
                arrayofShapes[1] = new Ellipse(10, 20);

                foreach (var item in arrayofShapes)
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }

    }
}
