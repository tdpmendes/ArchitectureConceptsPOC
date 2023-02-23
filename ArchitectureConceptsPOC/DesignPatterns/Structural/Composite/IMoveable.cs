using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Composite
{
    public interface IMoveable
    {
        public void Move(float x, float y, float xOffset = 0, float yOffset = 0);

    }
}
