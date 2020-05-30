using DisplayMultipleTablesInSingleViewMvc_Demo.Models;
using System.Collections.Generic;

namespace DisplayMultipleTablesInSingleViewMvc_Demo.ViewModel
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Incentive> Incentives { get; set; }
    }
}