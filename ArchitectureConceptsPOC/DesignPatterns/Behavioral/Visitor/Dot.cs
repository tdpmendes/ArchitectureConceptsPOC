using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Visitor
{
    public class Dot : IShape
    {
        public void Accept(IVisitor v)
        {
            v.VisitDot(this);
        }

        public void Draw()
        {
            Console.WriteLine("Draw Dot");
        }

        public void Move(float x, float y)
        {
            Console.WriteLine($"Moving Dot to ({x},{y})");    
        }
    }
}
