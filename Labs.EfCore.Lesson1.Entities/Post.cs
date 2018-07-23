namespace Labs.EfCore.Lesson1.Entities
{
  using System;
  using Base;

  public class Post : EntityBase<int>
  {
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishedDateTime { get; set; }

    public int BlogId { get; set; }

    public virtual Blog Blog { get; set; }
  }
}