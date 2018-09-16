namespace WebStore.Domain.Models.Base
{
    public interface INameEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}
