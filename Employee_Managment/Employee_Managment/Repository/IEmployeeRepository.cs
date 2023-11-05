using Employee_Managment.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee_Managment.Repository
{
    public interface IEmployeeRepository : IDisposable
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task CreateEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
        Task<IEnumerable<Employee>> GetEmployeesForDateRangeAsync(DateTime startDate, DateTime endDate);

        Task CreatePunchEventAsync(PunchEvent punchEvent);

    }

}
