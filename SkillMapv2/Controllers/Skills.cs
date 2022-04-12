using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skill_Map.Controllers
{ 
    public class Skills : Controller { 
    /*
    {
        private readonly Repos.EmployeeRepos _employeeRepo;
        public Skills(Repos.EmployeeRepos employeeRepo)
        {

        }
        */
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
    }
}
