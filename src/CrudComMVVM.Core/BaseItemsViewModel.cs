using System.Collections.ObjectModel;

namespace CrudComMVVM.Core
{
    public class BaseItemsViewModel<TEntity> : BaseViewModel<TEntity>
        where TEntity : BaseEntity, new()
    {
        #region Local Variables

        private TEntity _selectedItem;

        #endregion

        #region Properties

        public ObservableCollection<TEntity> Items { get; } = new ObservableCollection<TEntity>();

        public TEntity SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                DetailsItem = value;
                SetField(ref _selectedItem, value);
            }
        }

        #endregion
    }
}
