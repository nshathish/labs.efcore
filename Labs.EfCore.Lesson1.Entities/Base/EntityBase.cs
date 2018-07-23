namespace Labs.EfCore.Lesson1.Entities.Base
{
  using System.ComponentModel.DataAnnotations;

  public abstract class EntityBase<T> where T : struct
  {
    [Key]
    public T Id { get; set; }

    [Timestamp]
    public byte[] Timestamp { get; set; }
  }
}