using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Composite
{
    public class Circle : Dot
    {
        public float Radius { get; set; }

        public Circle(float x, float y,float radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Move(float x, float y, float xOffset, float yOffset)
        {
            Console.WriteLine($"Movendo Círculo com raio {Radius} de: ({X},{Y}) | para: ({x+xOffset},{y+yOffset})");
            X = x; Y = y;
        }

        public override void Draw()
        {
            Console.WriteLine($"Desenhando Círculo com raio {Radius} em: ({X},{Y})");
        }
    }
}
