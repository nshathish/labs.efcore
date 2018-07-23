namespace Labs.EfCore.Lesson1.Entities
{
  using System.Collections.Generic;
  using Base;

  public class Blog : EntityBase<int>
  {
    public string Url { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
  }
}