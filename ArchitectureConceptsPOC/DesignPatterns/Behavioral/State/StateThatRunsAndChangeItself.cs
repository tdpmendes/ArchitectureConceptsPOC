using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.State
{
    public class StateThatRunsAndChangeItself : IState
    {
        private Context _context;

        public StateThatRunsAndChangeItself(Context context)
        {
            _context = context;
        }

        public void Execute()
        {
            Console.WriteLine("State that changes itself is Running");
            var some = new SomeState();
            _context.StateChangeTo(some);
        }

        public void SetContext(Context context)
        {
            _context = context;
        }
    }
}
