using System;
using CodeFirst.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CodeFirst.DataAccess.Migrations.SqlServerDb
{
    public class SqlServerDbContextFactory : IDesignTimeDbContextFactory<SqlServerDbContext>
    {
        public SqlServerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlServerDbContext>();
            //var connectionString = Environment.GetEnvironmentVariable("SQLSERVER_MOVIES_LOCAL_CONNSTR");
            var connectionString =
                "Data Source=DAVID-NOTEBOOK\\SQLEXPRESS;Initial Catalog=MoviesDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connectionString
                                        ?? throw new NullReferenceException(
                                            $"Connection string is not got from environment {nameof(connectionString)}"));

            return new SqlServerDbContext(optionsBuilder.Options);
        }
    }
}