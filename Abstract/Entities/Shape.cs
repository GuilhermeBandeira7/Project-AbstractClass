using Abstract.Entities.Enum;

namespace Abstract.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

       // we do not use an empty constructor to obligate a instance of color

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // abstract class implementation. This method is generic for the especific situation so it has to be abstract along with the class
      
    }
}
