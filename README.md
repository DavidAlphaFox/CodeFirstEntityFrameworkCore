# Code First with Entity Framework

## Data base schema

## Which packages to use?

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer
- Npgsql.EntityFrameworkCore.PostgreSQL

## Roadmap

- Create a separate project Models, where data models are stored
- Create a separate project DataAccess, that is responsible for interraction with database
- Load packages to DataAccess project. See section Which packages to use?
- Inside project DataAccess create SqlServerDbContext, inherrit it from DbContext in Entity Framework
- Inside project DataAccess create PostgeSqlDbContext, inherrit it from DbContext in Entity Framework
- Get proper connection string for SQL Server database. For localhost it is: "Data Source=DESKTOP-P87PH2B;Initial Catalog=CodeFirstEntityFramework;Integrated Security=true;"
- Get proper connection string for Postgre SQL database. For localhost it is: "Server=localhost;User Id=postgres;Password=postgres;Database=CodeFirstEntityFramework;"