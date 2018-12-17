namespace CrudComMVVM.Core.ViewModels
{
    public interface IDetailsViewModel
    {
    }

    public interface IDetailsViewModel<TEntity> : IDetailsViewModel
        where TEntity : BaseEntity, new()
    {
        TEntity CurrentItem { get; set; }
    }
}
