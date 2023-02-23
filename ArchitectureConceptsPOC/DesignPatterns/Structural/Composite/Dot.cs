using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Composite
{
    public class Dot : IGraphic
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Dot(float x ,float y)
        {
            X = x;
            Y = y;
        }

        public virtual void Move(float x, float y, float xOffset, float yOffset)
        {
            Console.WriteLine($"Movendo Ponto de: ({X},{Y}) | para: ({x+xOffset},{y+yOffset}) ");
            X = x; Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Desenhando Ponto em: ({X},{Y})");
        }
    }
}
