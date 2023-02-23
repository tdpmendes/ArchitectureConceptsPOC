using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Facade
{
    public interface IAlgumService
    {
        public void TratarRequest(AlgumRequestDto request);
    }
}
