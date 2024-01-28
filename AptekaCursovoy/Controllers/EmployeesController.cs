using AptekaCursovoy.Components.Pages.Employees;
using AptekaCursovoy.Data;
using AptekaCursovoy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AptekaCursovoy.Controllers
{
    public class EmployeesController : Controller
    {
        private AptekaCursovoyContext dbContext;

        public EmployeesController(AptekaCursovoyContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await dbContext.Employee.ToListAsync();
        }


        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {

            dbContext.Employee.Add(employee);
            await dbContext.SaveChangesAsync();

            return employee;
        }
        public async Task<Employee> GetEmployeeAsync(int id)
        {
            var employee = await dbContext.Employee.FirstOrDefaultAsync(c => c.Id == id);
            await dbContext.SaveChangesAsync();

            return employee;
        }


        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            dbContext.Employee.Update(employee);
            await dbContext.SaveChangesAsync();

            return true;
        }


        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {

            dbContext.Employee.Remove(employee);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
