using Microsoft.AspNetCore.Mvc;
using InleveropdrGijs.Models;
using InleveropdrGijs.Data;
using Microsoft.EntityFrameworkCore;

namespace InleveropdrGijs.Controllers
{
    public class CooleController : Controller
    {
        private readonly AppDbContext database;

        public CooleController(AppDbContext database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            IEnumerable<Account> objAccountList = database.Accounts;
            return View(objAccountList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account accounts)
        {
            database.Accounts.Add(accounts);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    
    
    }

}
