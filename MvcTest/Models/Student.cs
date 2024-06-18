using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTest.Models;
 [Table("Student")]
public class Student : Person
{
    public int Id { get; set; }
    public string TenHS { get; set; }
    public char STT { get; set; }
}