using System.Collections.ObjectModel;

namespace CrudComMVVM.Core.ViewModels
{
    public interface IItemsViewModel<TEntity>
        where TEntity : BaseEntity, new()
    {
        ObservableCollection<TEntity> Items { get; }
        TEntity SelectedItem { get; set; }
        IDetailsViewModel<TEntity> DetailsViewModel { get; }
    }
}