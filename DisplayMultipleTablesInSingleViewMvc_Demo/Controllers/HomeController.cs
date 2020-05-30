using DisplayMultipleTablesInSingleViewMvc_Demo.Data;
using DisplayMultipleTablesInSingleViewMvc_Demo.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DisplayMultipleTablesInSingleViewMvc_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var employeeViewModel = new EmployeeViewModel
            {
                Employees = db.Employees.Include(e => e.Department).ToList(),
                Departments = db.Departments.ToList(),
                Incentives = db.Incentive.ToList()
            };
            return View(employeeViewModel);
        }
    }
}