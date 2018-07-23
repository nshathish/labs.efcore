namespace Labs.EfCore.Lesson1.Entities
{
  using System;
  using Base;
  using Framework;

  public class Post : EntityBase<int>
  {
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishedDateTime { get; set; }

    public int BlogId { get; set; }
    public string UserId { get; set; }

    public virtual Blog Blog { get; set; }
    public virtual AppUser User { get; set; }
  }
}