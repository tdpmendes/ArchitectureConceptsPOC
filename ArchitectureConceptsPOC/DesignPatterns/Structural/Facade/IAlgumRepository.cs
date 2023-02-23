using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Facade
{
    public interface IAlgumRepository
    {
        public void InsertAlgumModel(AlgumModel model);
        public void UpdateAlgumModel(AlgumModel model);
        public IList<AlgumModel> GetAllAlgumModel();
    }
}
