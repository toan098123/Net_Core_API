using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    
    public class Employee : Person
    {
        public required string EmployeeId { get; set; }
    }
}