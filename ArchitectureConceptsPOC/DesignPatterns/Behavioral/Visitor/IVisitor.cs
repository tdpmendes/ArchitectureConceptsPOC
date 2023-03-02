using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        public void VisitDot(Dot d);
        public void VisitCircle(Circle c);
        public void VisitCompoundGraphic(CompoundGraphic cg);
    }
}
