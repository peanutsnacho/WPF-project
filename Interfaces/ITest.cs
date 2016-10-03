using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITest
    {
        int TestID { get; set; }
        string Name { get; set; }
        bool HasMultipleAnswers { get; set; }
        TimeSpan Duration { get; set; }
    }
}
