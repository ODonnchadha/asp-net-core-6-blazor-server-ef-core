using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Entities;

namespace WiredBrainCoffee.EmployeeManager.Contexts
{
    public class EmployeeManagerDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();

        public EmployeeManagerDbContext(
            DbContextOptions<EmployeeManagerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>()
                .HasData(
                    new Department { Id = 1, Name = "Finance" },
                    new Department { Id = 2, Name = "Sales" },
                    new Department { Id = 3, Name = "Marketing" },
                    new Department { Id = 4, Name = "Human Resources" },
                    new Department { Id = 5, Name = "IT" });

            builder.Entity<Employee>()
            .HasData(
                new Employee { Id = 1, FirstName = "Anna", LastName = "Rockstar", DepartmentId = 2, IsDeveloper = false },
                new Employee { Id = 2, FirstName = "Julia", LastName = "Developer", DepartmentId = 5, IsDeveloper = true },
			    new Employee { Id = 3, FirstName = "Lily", LastName = "Valley", DepartmentId = 4, IsDeveloper = false },
				new Employee { Id = 4, FirstName = "Corky", LastName = "Delve", DepartmentId = 5, IsDeveloper = true },
				new Employee { Id = 5, FirstName = "Jeff", LastName = "Britian", DepartmentId = 2, IsDeveloper = false },
				new Employee { Id = 6, FirstName = "Andrew", LastName = "McCoy", DepartmentId = 5, IsDeveloper = true },
				new Employee { Id = 7, FirstName = "Salesboat", LastName = "F.", DepartmentId = 1, IsDeveloper = false },
				new Employee { Id = 8, FirstName = "Walt", LastName = "Mink", DepartmentId = 3, IsDeveloper = false },
				new Employee { Id = 9, FirstName = "Showboat", LastName = "Wells", DepartmentId = 2, IsDeveloper = false },
				new Employee { Id = 10, FirstName = "Stephanie", LastName = "Shucks", DepartmentId = 4, IsDeveloper = false },
				new Employee { Id = 11, FirstName = "Betty", LastName = "Ford", DepartmentId = 5, IsDeveloper = true },
				new Employee { Id = 12, FirstName = "Kitchen", LastName = "Half", DepartmentId = 1, IsDeveloper = false },
				new Employee { Id = 13, FirstName = "Bev", LastName = "Bevins", DepartmentId = 5, IsDeveloper = true },
				new Employee { Id = 14, FirstName = "Anderson", LastName = "McMurray", DepartmentId = 3, IsDeveloper = false },
				new Employee { Id = 15, FirstName = "X.", LastName = "Spot", DepartmentId = 2, IsDeveloper = false });
        }
    }
}
