using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Command
{
    public class TargetActionTwoCommand : ICommand
    {
        private ITargetModelObject _targetModelObject;
        public TargetActionTwoCommand(ITargetModelObject doc)
        {
            _targetModelObject = doc ?? throw new ArgumentNullException(nameof(doc));
        }
        public void Execute()
        {
            Console.WriteLine("Target Action Two is Running: ");
            _targetModelObject.TargetAction2();
        }
    }
}
