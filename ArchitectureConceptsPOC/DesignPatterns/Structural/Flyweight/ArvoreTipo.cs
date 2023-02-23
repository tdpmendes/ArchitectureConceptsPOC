using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Flyweight
{
    public class ArvoreTipo
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public string Texture { get; private set; }

        public ArvoreTipo(string name, string color, string texture)
        {
            Name = name; Color = color; Texture = texture;
        }

        public override string ToString()
        {
            return $"Name: {Name} | Color: {Color} | Texture: {Texture}";
        }

        public void Draw(string canvas, float x, float y)
        {

        }
    }
}
