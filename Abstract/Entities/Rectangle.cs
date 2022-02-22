using Abstract.Entities.Enum;


namespace Abstract.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Heigth = height;    
        }
        public override double Area() // we need to implement the abstract operation to create a new class inheriting Shape class
        {
            return Width * Heigth;
        }
    }
}
