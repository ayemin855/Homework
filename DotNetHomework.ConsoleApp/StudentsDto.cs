using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet;

[Table("tbl_students")]
public class StudentsDto
{
    [Key]
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
    public string? FatherName { get; set; }
    public DateTime? DOB { get; set; }
    public string? Address { get; set; }
    public string? MobileNumber { get; set; }
}
