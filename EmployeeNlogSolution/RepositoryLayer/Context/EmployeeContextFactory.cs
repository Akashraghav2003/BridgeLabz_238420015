using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Context;
using System;
using System.IO;

public class UserRegistrationContextFactory : IDesignTimeDbContextFactory<EmployeeContext>
{
    public EmployeeContext CreateDbContext(string[] args)
    {
        // Explicitly setting the path to the 'EmployeeRegistration' folder
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\EmployeeRegistration");

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath) // Ensuring correct appsettings.json location
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        string connectionString = configuration.GetConnectionString("SqlConnection");

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException("connectionString", "Database connection string is missing.");
        }

        var optionsBuilder = new DbContextOptionsBuilder<EmployeeContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new EmployeeContext(optionsBuilder.Options);
    }
}
