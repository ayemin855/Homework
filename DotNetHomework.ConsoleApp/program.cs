// See https://aka.ms/new-console-template for more information
using DotNet;
using PWTAdoDotNetHomework.ConsoleApp;

AppDbContext db = new AppDbContext();
List<FinanceDto> finances = db.Finances.ToList();
foreach (var lt in finances)
{
    Console.WriteLine($"{lt.Amount} {lt.Type} - {lt.CollectDate}");
}

FinanceDto record = new FinanceDto()
{
    Amount = 5000,
    Type = "Tuition Fee",
    CollectDate = DateTime.Now,
    CreatedById = 1,
};
db.Finances.Add(record);
db.SaveChanges();

FinanceDto? editRecord = db.Finances.Where(x => x.Id == 2).FirstOrDefault();
if (editRecord is not null)
{
    editRecord.Amount = 6000;
    db.SaveChanges();
    Console.WriteLine("Updated");
}

// FinanceDto? removeRecord = db.Finances.Where(x => x.Id == 1).FirstOrDefault();
// if (removeRecord is not null)
// {
//     db.Finances.Remove(removeRecord);
//     db.SaveChanges();
// }

Console.WriteLine("Finished!");

Console.ReadLine();