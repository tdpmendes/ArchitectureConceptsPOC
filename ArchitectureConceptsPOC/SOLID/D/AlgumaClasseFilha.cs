using System;

namespace ArchitectureConceptsPOC.D
{
    public class AlgumaClasseFilha : AlgumaClasseBase
    {
        public void AlgumServicoClasseFilha()
        {
            base.AlgumServicoBase();
            Console.WriteLine("Algum Servico Classe Filha");
        }
    }
}
