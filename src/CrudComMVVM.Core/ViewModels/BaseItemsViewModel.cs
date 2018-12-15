using System.Collections.ObjectModel;

namespace CrudComMVVM.Core.ViewModels
{
    public abstract class BaseItemsViewModel<TEntity> : BaseViewModel, IItemsViewModel<TEntity>
        where TEntity : BaseEntity, new()
    {
        #region Local Variables

        private TEntity _selectedItem;

        #endregion

        #region Constructors

        public BaseItemsViewModel(IDetailsViewModel<TEntity> detailsViewModel)
        {
            DetailsViewModel = detailsViewModel ?? throw new System.ArgumentNullException(nameof(detailsViewModel));
        }

        #endregion

        #region Properties

        public ObservableCollection<TEntity> Items { get; } = new ObservableCollection<TEntity>();

        public TEntity SelectedItem
        {
            get { return _selectedItem; }
            set { SetField(ref _selectedItem, value); }
        }

        public IDetailsViewModel<TEntity> DetailsViewModel { get; }

        #endregion
    }
}
