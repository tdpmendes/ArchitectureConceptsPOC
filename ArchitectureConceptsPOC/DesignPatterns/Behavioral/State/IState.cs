using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.State
{
    public interface IState
    {
        void Execute();
        void SetContext(Context context);
    }
}
