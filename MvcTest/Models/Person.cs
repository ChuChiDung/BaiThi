using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTest.Models;
 [Table("Person")]
 public class Person {
    [Key]
    public int Id { get; set;}
    public string Name { get; set;}

}