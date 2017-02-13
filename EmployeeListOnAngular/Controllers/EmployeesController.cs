using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using EmployeeListOnAngular.Models;

namespace EmployeeListOnAngular.Controllers
{
    public class EmployeesController : ApiController
    {
        private EmployeeListOnAngularContext db = new EmployeeListOnAngularContext();

        public IQueryable<Employee> GetEmployees()
        {
            return db.Employees;
        }
        
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employees.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.EmployeeId }, employee);
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.EmployeeId == id) > 0;
        }
    }
}