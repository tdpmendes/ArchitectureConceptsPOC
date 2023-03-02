using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Visitor
{
    public interface IShape
    {
        public void Move(float x, float y);
        public void Draw();
        public void Accept(IVisitor v);
    }
}
