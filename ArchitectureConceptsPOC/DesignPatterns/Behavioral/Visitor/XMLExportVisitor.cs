using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Visitor
{
    public class XMLExportVisitor : IVisitor
    {
        public void VisitCircle(Circle c)
        {
            c.Move(10, 10);
            c.Draw();
        }

        public void VisitCompoundGraphic(CompoundGraphic cg)
        {
            cg.Move(20, 20);
            cg.Draw();
        }

        public void VisitDot(Dot d)
        {
            d.Move(40, 40);
            d.Draw();
        }
    }
}
