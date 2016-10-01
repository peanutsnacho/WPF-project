using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDAO
    {
        IEnumerable<IProducer> getAllProducers();
        IEnumerable<ICar> getAllCars();

        ICar CreateNewCar();
        void AddCar(ICar car);
    }
}
