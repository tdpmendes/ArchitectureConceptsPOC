using System;

namespace ArchitectureConceptsPOC.O
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
