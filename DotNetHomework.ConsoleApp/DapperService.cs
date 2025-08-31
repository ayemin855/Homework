using System;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DotNet;

public class DapperService
{
    SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
    {
        DataSource = ".",
        InitialCatalog = "AMT_INPERSON_BATCH1",
        UserID = "sa",
        Password = "sasa@123",
        TrustServerCertificate = true,
    };

    public void Read()
    {
        using IDbConnection db = new SqlConnection(sb.ConnectionString);

        db.Open();

        List<Students> students = db.Query<Students>("SELECT * FROM dbo.tbl_students").ToList();

        db.Close();

        foreach (var student in students)
        {
            Console.WriteLine($"{student.StudentId} {student.StudentName} {student.MobileNumber}");
        }
    }
}
