using Chain_Of_Responsibilty.ChainOfResponsibilty;
using Microsoft.AspNetCore.Mvc;

namespace Chain_Of_Responsibilty.Controllers
{
    public class BankController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Index(Withdraw p)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee areaManager = new AreaManager();



            treasurer.SetNextApprover(managerAsistant);
            managerAsistant.SetNextApprover(manager);
            manager.SetNextApprover(areaManager);



            treasurer.ProcessRequest(p);



            return View();
        }
    }
}
