using WithDependencyInjection.Models;

namespace WithDependencyInjection.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee GetById(int id);
    }
}
