using Employee_Managment.Context;
using Employee_Managment.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Managment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.Where(e => !e.IsDeleted).ToListAsync();
        }
        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted);
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee != null)
            {
                employee.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
