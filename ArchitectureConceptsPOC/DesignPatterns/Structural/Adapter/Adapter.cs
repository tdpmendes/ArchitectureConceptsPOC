using ArchitectureConceptsPOC.DesignPatterns.Structural.Adapter.CodigoExistente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Adapter
{
    public class Adapter : IAdapter
    {
        private readonly IServico _servico;
        public Adapter(IServico servico)
        {
            _servico = servico ?? throw new ArgumentNullException(nameof(servico));
        }

        public bool Executar(AlgumRequestDto request)
        {
            BaseRequest requestAdaptado = AdaptarRequestAoServico(request);
            _servico.Executar(requestAdaptado);

            return true;
        }

        private BaseRequest AdaptarRequestAoServico(AlgumRequestDto nossoRequest)
        {
            ServicoRequestDto requestDeles = new ServicoRequestDto();
            var id = nossoRequest.Id.GetHashCode();
            var nome = nossoRequest.Nome;

            IDictionary<string, string> parametros = new Dictionary<string, string>();
            parametros.Add("Nome", nome);

            return new BaseRequest()
            {
                Id = id,
                Parametros = parametros
            };
        }
    }
}
