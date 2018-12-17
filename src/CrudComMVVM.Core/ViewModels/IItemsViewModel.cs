using System.Collections.ObjectModel;

namespace CrudComMVVM.Core.ViewModels
{
    public interface IItemsViewModel
    {
    }

    public interface IItemsViewModel<TEntity> : IItemsViewModel
        where TEntity : BaseEntity, new()
    {
        ObservableCollection<TEntity> Items { get; }
        TEntity SelectedItem { get; set; }
        IDetailsViewModel<TEntity> DetailsViewModel { get; }
    }
}