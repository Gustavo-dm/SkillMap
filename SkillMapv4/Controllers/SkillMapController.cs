using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkillMapv4.Data;
using SkillMapv4.Models;
namespace SkillMapv4.Controllers
{
    public class SkillMapController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SkillMapController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Employee> employees;
            employees = _context.Employees.ToList();

            return View(employees);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            Employee employee = new Employee();

            employee.Skills.Add(new Skills() { SkillID = 1 });


            return View(employee);
        }
        /// <summary>
        /// Create E
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
           
            var emp = _context.Employees.Where(c => c.Id == id).FirstOrDefault();
            if (emp != null)
                return View(emp);
                _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var emp = _context.Employees.Where(c => c.Id == id).FirstOrDefault();

            var Skills = _context.Skills.Where(c => c.EmployeeId == id).ToList();

         
            if (emp != null)
                return View(emp);
           

           

            return View(emp);
            
        }

        /// <summary>
        /// Delete registro
        /// </summary>
        /// <param name="id"> id do item</param>
        /// <returns>View</returns>
        public IActionResult Apagar(int id)
        {
            var emp = _context.Employees.Where(c => c.Id == id).FirstOrDefault();

            if (emp!=null)
                _context.Remove(emp);
                _context.SaveChanges();
                
            return RedirectToAction("Index");
        }
    }
}