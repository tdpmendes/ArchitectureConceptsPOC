using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Facade
{
    public class AlgumRepository : IAlgumRepository
    {
        public IList<AlgumModel> GetAllAlgumModel()
        {
            return new List<AlgumModel>();
        }

        public void InsertAlgumModel(AlgumModel model)
        {
        }

        public void UpdateAlgumModel(AlgumModel model)
        {
        }
    }
}
