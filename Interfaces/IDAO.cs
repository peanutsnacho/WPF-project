﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDAO
    {
        IEnumerable<ITest> GetAllTests();
        void AddNewTest(ITest test);
        ITest CreateNewTest();
    }
}
