namespace Covid19TestTracker.Core
{
    public class Covid19Test
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public TestResult Result { get; set; }
    }
}
