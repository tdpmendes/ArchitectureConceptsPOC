using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Memento
{
    public class Memento<T> where T : State
    {
        private T _state { get; set; }
        public Memento(T state)
        {
            _state = state ?? throw new ArgumentNullException(nameof(state));
        }

        public T State { get
            {
                return _state;
            } 
        } 
    }
}
