using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Command
{
    public class TargetActionsModel : ITargetModelObject
    {
        private string Name { get; set; }

        public TargetActionsModel(string name)
        {
            Name = name;
        }
        
        public void TargetAction1()
        {
            Console.WriteLine($"Target Action 1 on {Name}");
        }

        public void TargetAction2()
        {
            Console.WriteLine($"Target Action 2 on {Name}");
        }

        public void TargetAction3()
        {
            Console.WriteLine($"Target Action 3 on {Name}");
        }
    }
}
