using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Flyweight
{
    public class Arvore
    {
        public float X { get; set; }
        public float Y { get; set; }
        public ArvoreTipo ArvoreTipo { get; set; }

        public void Draw (string canvas)
        {

        }
    }
}
