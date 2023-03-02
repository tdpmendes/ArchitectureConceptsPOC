using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.State
{
    public class SomeState : IState
    {
        private Context _context;
        public void Execute()
        {
            Console.WriteLine("Some State is Running");
        }

        public void SetContext(Context context)
        {
            _context = context;
        }
    }
}
