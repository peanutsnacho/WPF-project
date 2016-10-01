using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMMock1.BO
{
    public class DAO : IDAO
    {
        private List<IProducer> _producers;
        private List<ICar> _cars;

        public DAO()
        {
            _producers = new List<IProducer>()
            {
                new BO.Producer() {ProducerID=1, Name="Seat"},
                new BO.Producer() {ProducerID=2, Name="Opel"},
                new BO.Producer() {ProducerID=3, Name="Fiat"}
            };

            _cars = new List<ICar>()
            {
                new BO.Car() {CarID=1, Name="Cordoba", Price=9000, Producer=_producers[0], Color="red", ProdYear=2005},
                new BO.Car() {CarID=2, Name="Ibiza", Price=15000, Producer=_producers[0], Color="blue", ProdYear=2009},
                new BO.Car() {CarID=3, Name="Leon", Price=40000, Producer=_producers[0], Color="green", ProdYear=2015},
                new BO.Car() {CarID=4, Name="Vectra", Price=25000, Producer=_producers[1], Color="silver", ProdYear=2012},
                new BO.Car() {CarID=5, Name="Insignia", Price=10000, Producer=_producers[1], Color="blue", ProdYear=2002},
                new BO.Car() {CarID=6, Name="Punto", Price=8000, Producer=_producers[2], Color="red", ProdYear=2004},
                new BO.Car() {CarID=7, Name="500", Price=22000, Producer=_producers[2], Color="yellow", ProdYear=2013}
            };
        }

        public IEnumerable<IProducer> getAllProducers()
        {
            return _producers;
        }

        public IEnumerable<ICar> getAllCars()
        {
            return _cars;
        }


        public ICar CreateNewCar()
        {
            return new Car();
        }

        public void AddCar(ICar car)
        {
            _cars.Add(car);
        }
    }
}
