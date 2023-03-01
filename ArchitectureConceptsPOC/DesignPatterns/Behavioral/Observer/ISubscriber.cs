using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Observer
{
    public interface ISubscriber<T> where T: BaseMessage
    {
        void Update(T context);
    };
}
