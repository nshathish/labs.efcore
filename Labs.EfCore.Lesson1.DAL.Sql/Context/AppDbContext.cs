namespace Labs.EfCore.Lesson1.DAL.Sql.Context
{
  using Entities;
  using Entities.Framework;
  using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
  using Microsoft.EntityFrameworkCore;

  public class AppDbContext: IdentityDbContext<AppUser>
  {

    /*public AppDbContext()
    {
    }
*/
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

  }
}