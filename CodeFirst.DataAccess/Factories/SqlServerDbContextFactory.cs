using System;
using CodeFirst.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.DataAccess.Factories
{
    public class SqlServerDbContextFactory : IDbContextFactory<SqlServerDbContext>
    {

        public SqlServerDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlServerDbContext>();
            //var connectionString = Environment.GetEnvironmentVariable("SQLSERVER_MOVIES_LOCAL_CONNSTR");
            var connectionString =
                "Data Source=DAVID-NOTEBOOK\\SQLEXPRESS;Initial Catalog=MoviesDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            return new SqlServerDbContext(optionsBuilder.Options);
        }
    }
}