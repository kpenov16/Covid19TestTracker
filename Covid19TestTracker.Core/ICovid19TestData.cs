﻿using Covid19TestTracker.Core;
using System.Collections.Generic;
using System.Text;

namespace Covid19TestTracker.Core
{
    public interface ICovid19TestData
    {
        IEnumerable<Covid19Test> GetAll();

    }

}