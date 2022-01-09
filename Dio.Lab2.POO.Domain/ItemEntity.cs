namespace Dio.Lab2.POO.Domain
{
    public class ItemEntity : EntityBase
    {
        public virtual string? Title { get; set; }
        public virtual string? Description { get; set; }
        public virtual int? Year { get; set; }
        public virtual CategoryEntity? Category { get; set; }
    }
}
