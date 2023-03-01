using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Memento
{
    public class Originator<T> where T : State, new()
    {
        private T _state;
        public Memento<T> Save()
        {
            _state = new T();
            return new Memento<T>(_state);
        } 

        public void Restore(Memento<T> memento)
        {
            _state = memento.State;
        }
    }
}
