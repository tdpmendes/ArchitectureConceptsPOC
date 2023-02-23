using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Facade
{
    public class AlgumOutroRepository : IAlgumOutroRepository
    {
        public IList<AlgumOutroModel> GetAllAlgumOutroModel()
        {
            return new List<AlgumOutroModel>();
        }

        public void InsertAlgumOutroModel(AlgumOutroModel model)
        {
        }

        public void UpdateAlgumOutroModel(AlgumOutroModel model)
        {
        }
    }
}
