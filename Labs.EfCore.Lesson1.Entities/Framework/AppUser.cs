namespace Labs.EfCore.Lesson1.Entities.Framework
{
  using Microsoft.AspNetCore.Identity;

  public class AppUser : IdentityUser
  {
    public string FirstName { get; set; }  
    public string LastName { get; set; }
  }
}