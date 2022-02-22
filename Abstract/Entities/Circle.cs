using Abstract.Entities.Enum;


namespace Abstract.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, Color color ) : base(color)
        {
            Radius = radius;
        }

        public override double Area() // we need to implement the abstract operation to create a new class inheriting Shape class
        {
            return Math.PI * Radius * Radius;
        }
    }
}
