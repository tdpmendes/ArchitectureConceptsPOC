using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Facade
{
    public interface IAlgumOutroRepository
    {
        public void InsertAlgumOutroModel(AlgumOutroModel model);
        public void UpdateAlgumOutroModel(AlgumOutroModel model);
        public IList<AlgumOutroModel> GetAllAlgumOutroModel();

    }
}
