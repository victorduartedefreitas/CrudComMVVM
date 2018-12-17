namespace CrudComMVVM.Core.Views
{
    public interface IItemsView
    {
    }

    public interface IItemsView<TEntity> : IItemsView
        where TEntity : BaseEntity, new()
    {
    }
}
