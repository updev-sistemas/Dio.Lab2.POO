namespace Dio.Lab2.POO.Domain
{
    public abstract class EntityBase
    {
        public virtual int? Id { get; set; }
        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? UpdatedAt { get; set; }
    }
}
