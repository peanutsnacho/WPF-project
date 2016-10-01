using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMMock1.BO
{
    public class Producer : IProducer
    {

        public int ProducerID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
