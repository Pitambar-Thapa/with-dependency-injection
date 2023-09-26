using WithDependencyInjection.Models;

namespace WithDependencyInjection.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public List<Employee> DataSource()
        {
            return new List<Employee>()
            {
                new Employee() { EmployeeId = 1, Name = "James", Department = "Development", Address = "A",Email="James@gmail.com", Gender = "Male" },
                new Employee() { EmployeeId = 2, Name = "Smith", Department = "Management", Address = "B",Email="Smith@gmail.com", Gender = "Male" },
                new Employee() { EmployeeId = 3, Name = "David", Department = "Sales", Address = "A",Email="David@gmail.com", Gender = "Male" },
                new Employee() { EmployeeId = 4, Name = "Sara",  Department = "Development", Address = "A",Email="Sara@gmail.com", Gender = "Female" },
                new Employee() { EmployeeId = 5, Name = "Pam",   Department = "Management", Address = "B",Email="Pam@gmail.com", Gender = "Female" }
            };
        }
        public List<Employee> GetAll()
        {
            return DataSource();
        }

        public Employee GetById(int id)
        {
            return DataSource().FirstOrDefault(x => x.EmployeeId == id) ?? new Employee();
        }
    }
}
