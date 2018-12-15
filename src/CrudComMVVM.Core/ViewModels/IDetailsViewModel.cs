namespace CrudComMVVM.Core.ViewModels
{
    public interface IDetailsViewModel<TEntity>
        where TEntity : BaseEntity, new()
    {
        TEntity CurrentItem { get; set; }
    }
}
