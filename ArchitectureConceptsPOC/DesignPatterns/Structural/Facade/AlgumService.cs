using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Facade
{
    public class AlgumService : IAlgumService
    {
        private IAlgumRepository _algumRepository;
        private IAlgumOutroRepository _algumOutroRepository;

        public AlgumService(IAlgumRepository repository, 
                            IAlgumOutroRepository algumOutroRepository)
        {
            _algumRepository = 
                repository ?? throw new ArgumentNullException(nameof(repository));
            _algumOutroRepository = 
                algumOutroRepository ?? throw new ArgumentNullException(nameof(algumOutroRepository));
        }

        public void TratarRequest(AlgumRequestDto request)
        {
            _algumRepository.InsertAlgumModel(request.AlgumModel);
            _algumOutroRepository.InsertAlgumOutroModel(request.AlgumOutroModel);
        }
    }
}
