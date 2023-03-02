using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Strategy
{
    public class Multiply : IStrategy
    {
        public void Execute(DataDto data)
        {
            var result = data.a * data.b;
            Console.WriteLine($"Mult is {result}");
        }
    }
}
