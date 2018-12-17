using CrudComMVVM.Core.ViewModels;
using CrudComMVVM.Core.Views;
using System;
using System.Windows.Controls;

namespace CrudComMVVM.Core.Controls.Views
{
    public abstract class BaseItemsView<TEntity> : UserControl, IItemsView<TEntity>
        where TEntity : BaseEntity, new()
    {
        public BaseItemsView(IItemsViewModel itemsViewModel)
        {
            DataContext = itemsViewModel ?? throw new ArgumentNullException(nameof(itemsViewModel));
        }
    }
}
