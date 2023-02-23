using System;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Adapter
{
    public class AlgumRequestDto : Dto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
