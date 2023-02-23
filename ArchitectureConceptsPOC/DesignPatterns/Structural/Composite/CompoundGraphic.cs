using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Composite
{
    public class CompoundGraphic : IGraphic
    {
        public IList<IGraphic> Children = new List<IGraphic>();

        public void Add(IGraphic graphic)
        {
            Children.Add(graphic);
        }
        public void Remove(IGraphic graphic)
        {
            Children.Remove(graphic);
        }

        public void Draw()
        {
            Console.WriteLine("Desenhando Elemento Gráfico Composto: ");
            foreach (var item in Children)
            {
                item.Draw();
            }
        }

        public void Move(float x, float y, float xOffset = 0, float yOffset = 0)
        {
            Console.WriteLine($"Movendo Elemento Gráfico Composto para: ({x+xOffset},{y+yOffset})");
            foreach (var item in Children)
            {
                item.Move(x, y,xOffset,yOffset);
            }
        }

    }
}
