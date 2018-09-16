namespace WebStore.Domain.Models.Base
{
    public interface IOrderEntity : INameEntity
    {
        int Order { get; set; }
    }
}
