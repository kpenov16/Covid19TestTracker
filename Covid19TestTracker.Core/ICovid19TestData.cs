using Covid19TestTracker.Core;
using System.Collections.Generic;
using System.Text;

namespace Covid19TestTracker.Core
{
    public interface ICovid19TestData
    {
        IEnumerable<Covid19Test> GetTestsByCpr(string cprNumber);
        Covid19Test getById(string id);
        Covid19Test Update(Covid19Test covid19Test);
        int Commit();

    }

}
