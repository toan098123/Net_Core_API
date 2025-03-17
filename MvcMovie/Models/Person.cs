using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
  [Table("Persons")]
  public class Person
  {
    [Key]
    public int Id {get; set; }
     public required string PersonId { get; set;}
     public required string FullName { get; set;}
     public required string Address { get; set;}

  }
}