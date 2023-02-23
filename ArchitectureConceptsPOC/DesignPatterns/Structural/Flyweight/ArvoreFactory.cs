using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Flyweight
{
    public class ArvoreFactory
    {
        private IList<ArvoreTipo> _arvoreTipos;

        public IList<ArvoreTipo> GetArvoreTipos(string name, string color, string texture)
        {
            return _arvoreTipos.Where(a => a.Name == name &&
                                           a.Color == color &&
                                           a.Texture == texture).ToList();
        }
    }
}
