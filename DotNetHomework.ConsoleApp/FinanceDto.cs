using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet;

[Table("tbl_finance")]
public class FinanceDto
{
    [Key]
    public int Id { get; set; }
    public int Amount { get; set; }
    public string Type { get; set; }    
    public DateTime CollectDate { get; set; }
    public int CreatedById { get; set; }
}
