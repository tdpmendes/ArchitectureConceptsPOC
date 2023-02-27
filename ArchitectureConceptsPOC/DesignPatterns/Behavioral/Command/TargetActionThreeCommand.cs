using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Command
{
    public class TargetActionThreeCommand : ICommand
    {
        private ITargetModelObject _targetModelObject;
        public TargetActionThreeCommand(ITargetModelObject obj)
        {
            _targetModelObject = obj ?? throw new ArgumentNullException(nameof(obj));
        }
        public void Execute()
        {
            Console.WriteLine("Target Action Three is Running: ");
            _targetModelObject.TargetAction3();
        }
    }
}
