using Employee_Managment.Models;

namespace Employee_Managment.Repository
{
    public interface IEmployeeRepository : IDisposable
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task CreateEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);

    }
}
