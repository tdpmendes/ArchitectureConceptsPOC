using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Visitor
{
    public class CompoundGraphic : IShape
    {
        public void Accept(IVisitor v)
        {
            v.VisitCompoundGraphic(this);
        }

        public void Draw()
        {
            Console.WriteLine("Draw CompoundGraphic");
        }

        public void Move(float x, float y)
        {
            Console.WriteLine($"Moving CompoundGraphic to ({x},{y})");
        }
    }
}
