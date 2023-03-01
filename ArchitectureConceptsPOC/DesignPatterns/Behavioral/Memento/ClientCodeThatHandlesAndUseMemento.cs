using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Memento
{
    public class ClientCodeThatHandlesAndUseMemento
    {
        private Originator<Dados> _originator;
        private Stack<Memento<Dados>> _history;

        public ClientCodeThatHandlesAndUseMemento()
        {
            _originator = new Originator<Dados>();
            _history = new Stack<Memento<Dados>>();
        }

        public void DoSomething()
        {
            var m = _originator.Save();

            m.State.Nome = "Meu Memento";
            m.State.Documento = "123456";
            m.State.Idade = 22;

            RegisterMemento(m.State);

            m = _originator.Save();
            m.State.Nome = "Seu Memento";

            RegisterMemento(m.State);

            m = _originator.Save();
            m.State.Nome = "Sua Marmota";

            m = Undo();


        }

        public void RegisterMemento(Dados dados)
        {
            var m = new Memento<Dados>(dados);
            _history.Push(m);
        }

        public Memento<Dados> Undo()
        {
            var m = _history.Pop();
            _originator.Restore(m);
            return m;
        }

    }
}
