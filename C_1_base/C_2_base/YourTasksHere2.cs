namespace C_2_base
{
    // Необходимо реализовать объектную модель геометрических фигур (прямоугольник, тругольник, круг).
    // Ко всем фигурам должно быть возможно осуществить доступ по одному имени 
    // Через это имя должно быть возможно получить доступ к площади и периметру фигур
    // Все числа пусть имееют тип double
    
    public interface Figure
    {
        double Square { get; }
        double Perim { get; }
    }

    public class Circle : Figure
    {
        private double radius;
        Circle(double r)
        {
            if (r > 0)
            {
                this.radius = r;
            }
            else throw new System.Exception("this is not a circle");
        }
        public double Square
        {
            get { return System.Math.PI * System.Math.Pow(radius, 2); }
        }
        public double Perim
        {
            get { return 2 * System.Math.PI * radius; }
        }
    }

    public class Triangle : Figure
    {
        //three sides
        private double A;
        private double B;
        private double C;
        Triangle(double a, double b, double c)
        {
            if ((a <= b + c) && (b <= a + c) && (c <= a + b))
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else throw new System.Exception("this is not a triangle");
        }
        public double Square
        {
            get
            {
                double p = this.Perim / 2;
                return System.Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
        public double Perim
        {
            get { return (A + B + C); }
        }
    }

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        Rectangle(double width, double height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else throw new System.Exception("this is not a rectangle");
        }

        public double Square
        {
            get { return width * height; }
        }
        public double Perim
        {
            get { return 2 * (width + height); }
        }
    }
}