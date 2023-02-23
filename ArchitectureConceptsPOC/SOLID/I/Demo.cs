using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.I
{
    public class Demo
    {
        public void Rodar()
        {
            UmaClasse classe = new UmaClasse();

            ServicoQuePedeOutroServicoQualquer(classe);
            ServicoQuePedeUmServicoQualquer(classe);
        }

        public void ServicoQuePedeUmServicoQualquer(IServicoQualquer servico)
        {
            servico.ServicoQualquer();
        }

        public void ServicoQuePedeOutroServicoQualquer(IOutroServicoQualquer servico)
        {
            servico.OutroServicoQualquer();
        }
        

    }
}
