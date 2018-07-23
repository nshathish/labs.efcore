namespace Labs.EfCore.Lesson1.Entities.Framework
{
  using System.Collections.Generic;
  using Microsoft.AspNetCore.Identity;

  public class AppUser : IdentityUser
  {
    public string FirstName { get; set; }  
    public string LastName { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
  }
}