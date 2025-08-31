using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DotNet;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "AMT_INPERSON_BATCH1",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,
        };

        optionsBuilder.UseSqlServer(sb.ConnectionString);
    }

    public DbSet<FinanceDto> Finances { get; set; }
}
