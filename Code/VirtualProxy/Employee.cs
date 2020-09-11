namespace VirtualProxy
{
    public sealed class Employee
    {
        public string EmployeeName { get; }
        public decimal EmployeeSalary { get; }
        public string EmployeeDesignation { get; }

        public Employee(string employeeName, decimal employeeSalary, string employeeDesignation)
        {
            EmployeeName = employeeName;
            EmployeeSalary = employeeSalary;
            EmployeeDesignation = employeeDesignation;
        }

        public override string ToString()
        {
            return $"Employee Name: {EmployeeName}, Employee Designation: {EmployeeDesignation}, Employee Salary: {EmployeeSalary.ToString()}";
        }
    }
}