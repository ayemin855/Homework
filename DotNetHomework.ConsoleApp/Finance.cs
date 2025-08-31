using System;

namespace DotNet;

public class Finance
{
   public int Id { get; set; }
    public int Amount { get; set; }
    public required string Type { get; set; }    
    public DateTime CollectDate { get; set; }
    public int CreatedById { get; set; }
}
