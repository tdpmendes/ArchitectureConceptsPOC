using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Facade
{
    public class AlgumRequestDto : Dto
    {
        public AlgumModel AlgumModel { get; set; }
        public AlgumOutroModel AlgumOutroModel { get; set; }
    }
}
