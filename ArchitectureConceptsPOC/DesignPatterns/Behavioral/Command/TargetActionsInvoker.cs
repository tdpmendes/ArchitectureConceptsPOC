using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Command
{
    public class TargetActionsInvoker
    {
        private ICommand TargetActionOneCommand;
        private ICommand TargetActionTwoCommand;
        private ICommand TargetActionThreeCommand;

        public TargetActionsInvoker(ICommand one, ICommand two, ICommand three)
        {
            TargetActionOneCommand = one;
            TargetActionTwoCommand = two;
            TargetActionThreeCommand = three;
        }

        public void clickOne()
        {
            TargetActionOneCommand.Execute();
        }

        public void clickTwo()
        {
            TargetActionTwoCommand.Execute();
        }

        public void clickThree()
        {
            TargetActionThreeCommand.Execute();
        }
    }
}
