namespace Labs.EfCore.Lesson1.DAL.Sql.Factory
{
  using System;
  using System.IO;
  using Microsoft.EntityFrameworkCore;
  using Microsoft.EntityFrameworkCore.Design;
  using Microsoft.Extensions.Configuration;

  public abstract class DesignTimeFactoryBase<T> : IDesignTimeDbContextFactory<T> where T: DbContext
  {
    public T CreateDbContext(string[] args)
    {
      var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appSettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<T>();
      var connectionStr = configuration.GetConnectionString("DefaultConnection");
      Console.Write(connectionStr);
      builder.UseSqlServer(connectionStr);

      return (T) Activator.CreateInstance(typeof(T), builder.Options);
    }
  }
}