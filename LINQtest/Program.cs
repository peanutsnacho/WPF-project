using Cars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Interfaces;
using Cars.DB_1;

namespace LINQtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var zm1 = new { Name = "Jurek", Age = 20};
            var zm2 = new { Name = "Jurek", Age = 20 };

            if(zm1.Equals(zm2))
            {
                Console.WriteLine("Takie same");
            } else
            {
                Console.WriteLine("inne");
            }

            Parking parking = new Parking();
            List<IProducer> producers = parking.GetAllProducers();
            List<ICar> cars = parking.GetAllCars();

            foreach (var p in producers)
            {
                Console.WriteLine("{0}. {0}", p.Id, p.Name);
            }
            Console.WriteLine("-------------------");

            foreach (var c in cars)
            {
                Console.WriteLine("{0} {1} z roku {2}", c.ProducerId, c.Name, c.ProdYear);
            }
            Console.WriteLine("-------------------");

            var list = from car in cars
                       select car; //typ anonimowy

            foreach (var c in list)
            {
                Console.WriteLine("{0} {1} z roku {2}", c.ProducerId, c.Name, c.ProdYear);
            }

            list = from car in cars
                   where car.ProdYear > 2005
                   select car;

            var list2 = from car in cars
                        join prod in producers on car.ProducerId equals prod.Id
                        select new { car.Name, car.ProdYear, ProducerName = prod.Name };

            var carProd = from prod in producers
                          join car in cars on prod.Id equals car.ProducerId into _cars
                          from car in _cars.DefaultIfEmpty()
                          select new { ProdName = prod.Name, CarName = (car == null) ? "no cars" : car.Name };

            Console.ReadKey();
        }
    }
}
