using System.Collections.Generic;

namespace Covid19TestTracker.Core
{
    public class Patient
    {
        public string Id { get; set; }
        public string CprNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Covid19Test> Covid19Tests { get; set; } = new List<Covid19Test>();
    }
}