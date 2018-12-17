namespace CrudComMVVM.Core.Views
{
    public interface IDetailsView
    {
    }

    public interface IDetailsView<TEntity> : IDetailsView
        where TEntity : BaseEntity, new()
    {
    }
}
