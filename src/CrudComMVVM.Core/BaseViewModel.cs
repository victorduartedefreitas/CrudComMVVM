using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CrudComMVVM.Core
{
    public abstract class BaseViewModel<TEntity> : INotifyPropertyChanged
        where TEntity : BaseEntity, new()
    {
        #region Local Variables

        private TEntity _selectedItem;
        private TEntity _detailsItem;

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

        public TEntity DetailsItem
        {
            get { return _detailsItem; }
            set { SetField(ref _detailsItem, value); }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Protected Methods

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetField<T>(ref T field, T value, [CallerMemberName]string propertyName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
            }
        }

        #endregion
    }
}
