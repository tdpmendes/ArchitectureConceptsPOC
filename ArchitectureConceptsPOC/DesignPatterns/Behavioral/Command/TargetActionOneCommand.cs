using System;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Command
{
    public class TargetActionOneCommand : ICommand
    {
        private ITargetModelObject _targetModelObject;
        public TargetActionOneCommand(ITargetModelObject doc)
        {
            _targetModelObject = doc ?? throw new ArgumentNullException(nameof(doc));
        }
        public void Execute()
        {
            Console.WriteLine("Open Command is Running: ");
            _targetModelObject.TargetAction1();
        }
    }
}
