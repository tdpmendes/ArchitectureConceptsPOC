using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Visitor
{
    public class Circle : IShape
    {
        public void Accept(IVisitor v)
        {
            v.VisitCircle(this);
        }

        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }

        public void Move(float x, float y)
        {
            Console.WriteLine($"Moving Circle to ({x},{y})");
        }
    }
}
