using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.Singleton
{
    public class Singleton
    {
        private static Singleton singleton { get; set; }

        public static Singleton Instancia {
            get
            {
                if (singleton == null) 
                    singleton = new Singleton();
                return singleton;
            }
        }
        public string Nome { get; set; } = "Instancia Unica";
    }
}
