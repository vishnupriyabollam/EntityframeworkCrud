using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Model;

namespace WebApplication3.Controllers
{
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            using (var _context = new EmployeeContext())
            {
                var listofEmployees = new List<EmployeeModel>();
                listofEmployees = _context.tableEmployee.ToList();
                return Ok(listofEmployees);
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] EmployeeModel employeeobject)
        {
            using (var _context = new EmployeeContext())
            {
                _context.tableEmployee.Add(employeeobject);
                _context.SaveChanges();
            }
            return Ok("posted Successfully");
        }
        [HttpPut]
        public ActionResult Put([FromBody] EmployeeModel employeeobject)
        {
            using (var _context = new EmployeeContext())
            {
                _context.tableEmployee.Update(employeeobject);
                _context.SaveChanges();
            }
            return Ok("updated Successfully");
        }
        [HttpDelete]
        public ActionResult Delete([FromBody]EmployeeModel Employeeobject)
        {
            using (var _context = new EmployeeContext())
            {
                
                _context.tableEmployee.Remove(Employeeobject);
                _context.SaveChanges();
            }
            return Ok("deleted");
        }
    }
}
