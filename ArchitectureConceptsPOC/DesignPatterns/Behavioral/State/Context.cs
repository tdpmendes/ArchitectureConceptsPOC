using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.State
{
    public class Context : IState
    {
        private IState _state;

        public Context(IState initialState)
        {
            _state = initialState;
            _state.SetContext(this);

        }

        public void Execute()
        {
            Console.WriteLine($"Context is running");
            _state.Execute();
            
        }

        public void SetContext(Context context)
        {
            _state.SetContext(context);
        }

        public void StateChangeTo(IState state)
        {
            _state = state;
        }
    }
}
