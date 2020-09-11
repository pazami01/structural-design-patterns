using System;

namespace ProtectedProxy
{
    public class ReportGeneratorProtectionProxy : IReportGeneratorProxy
    {
        private IReportGenerator _reportGenerator;
        private IStaff _staff;

        public ReportGeneratorProtectionProxy(IStaff staff)
        {
            _staff = staff;
        }

        public string GenerateDailyReport()
        {
            if (!_staff.IsOwner()) 
            {
                return "Not Authorised to view report.";
            }

            if (_reportGenerator == null)
            {
                _reportGenerator = new ReportGenerator();
            }

            return _reportGenerator.GenerateDailyReport();
        }
    }
}