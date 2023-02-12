using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffee.EmployeeManager.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "First Name is Required."), StringLength(50)]
        public string? FirstName { get; set; }

		[Required(ErrorMessage = "Last Name is Required."), StringLength(50)]
		public string? LastName { get; set; }

        public bool IsDeveloper { get; set; }

        [Required()]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        [Timestamp()]
        public byte[]? Timestamp { get; set; }
    }
}
