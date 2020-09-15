using Covid19TestTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Covid19TestTracker.Data
{
    public class InMemoryCovid19TestData : ICovid19TestData
    {

        List<Covid19Test> covid19Tests;

        public InMemoryCovid19TestData()
        {
            covid19Tests = new List<Covid19Test>();

            //Bob Marley
            var bob = new Patient()
            {
                Id = Guid.NewGuid().ToString(),
                CprNumber = "1001880203",
                FirstName = "Bob",
                LastName = "Marley",
                Covid19Tests = new List<Covid19Test>()
            };

            var bobTest1 = new Covid19Test
            {
                Id = Guid.NewGuid().ToString(),
                Description = "Extra info om testen",
                Location = "Hospital near the end of the world",
                Date = DateTime.Now.ToString(),
                Result = TestResult.None,
                Patient = bob
            };
            bob.Covid19Tests.Add(bobTest1);
            covid19Tests.Add(bobTest1);

            var bobTest2 = new Covid19Test
            {
                Id = Guid.NewGuid().ToString(),
                Description = "This boy need testing again..",
                Location = "Hospital near Roskilde",
                Date = DateTime.Now.ToString(),
                Result = TestResult.None,
                Patient = bob
            };
            bob.Covid19Tests.Add(bobTest2);
            covid19Tests.Add(bobTest2);


            //Billy Kid
            var billy = new Patient()
            {
                Id = Guid.NewGuid().ToString(),
                CprNumber = "2007930305",
                FirstName = "Billy",
                LastName = "Kid",
                Covid19Tests = new List<Covid19Test>()
            };

            var billyTest1 = new Covid19Test
            {
                Id = Guid.NewGuid().ToString(),
                Description = "Need to be tested again?",
                Location = "Hospital in Copenhagen",
                Date = DateTime.Now.ToString(),
                Result = TestResult.None,
                Patient = billy
            };
            billy.Covid19Tests.Add(billyTest1);
            covid19Tests.Add(billyTest1);

            var billyTest2 = new Covid19Test
            {
                Id = Guid.NewGuid().ToString(),
                Description = "This boy need testing again..",
                Location = "Hospital in Danmark",
                Date = DateTime.Now.ToString(),
                Result = TestResult.None,
                Patient = billy
            };
            billy.Covid19Tests.Add(billyTest2);
            covid19Tests.Add(billyTest2);

        }

        public Covid19Test getById(string id)
        {
            return covid19Tests.SingleOrDefault(t => t.Id == id);
        }

        public IEnumerable<Covid19Test> GetTestsByCpr(string cprNumber = null)
        {
            return from t in covid19Tests
                   where string.IsNullOrEmpty(cprNumber) || t.Patient.CprNumber.StartsWith(cprNumber)
                   orderby t.Date
                   select t;
        }
    }

}
