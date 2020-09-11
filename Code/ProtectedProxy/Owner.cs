namespace ProtectedProxy
{
    public class Owner : IStaff
    {
        public bool IsOwner()
        {
            return true;
        }

        public string GenerateDailyReport()
        {
            return ReportGenerator.GenerateDailyReport();
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}