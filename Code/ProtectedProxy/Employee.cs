namespace ProtectedProxy
{
    public class Employee : IStaff
    {
        public bool IsOwner()
        {
            return false;
        }

        public string GenerateDailyReport()
        {
            return ReportGenerator.GenerateDailyReport();
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}