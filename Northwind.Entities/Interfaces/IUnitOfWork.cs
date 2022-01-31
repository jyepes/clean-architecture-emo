namespace Northwind.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        ValueTask SaveChanges();
    }
}
