﻿using System;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.DataAccess.Factories;
using CodeFirst.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.ConsoleUI
{
    public static class Program
    {
        private static async Task Main()
        {
            /*
            var postFactory = new PostgresDbContextFactory();
            var postgreRepo = new MoviesRepository(postFactory.CreateDbContext(Array.Empty<string>()));
            var movies = await postgreRepo.GetAllAsync();
            movies.ToList().ForEach(Console.WriteLine);
            var getById = await postgreRepo.GetByIdAsync(3);
            Console.WriteLine(getById.Title);
            */
            var sqlFactory = new SqlServerDbContextFactory();
            var dbContext = sqlFactory.CreateDbContext();
            var sqlServerRepo = new MoviesRepository(dbContext);
            var movies = await sqlServerRepo.GetAllAsync();
            movies.ToList().ForEach(Console.WriteLine);
            var getById = await sqlServerRepo.GetByIdAsync(3);
            Console.WriteLine(getById.Title);
            var query = dbContext.Movies.Include(x => x.Copies);
            Console.WriteLine(query.ToQueryString());
        }
    }
}