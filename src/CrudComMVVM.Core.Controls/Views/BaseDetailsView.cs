using CrudComMVVM.Core.ViewModels;
using CrudComMVVM.Core.Views;
using System;
using System.Windows.Controls;

namespace CrudComMVVM.Core.Controls.Views
{
    public abstract class BaseDetailsView<TEntity> : UserControl, IDetailsView<TEntity>
        where TEntity : BaseEntity, new()
    {
        public BaseDetailsView(IDetailsViewModel detailsViewModel)
        {
            DataContext = detailsViewModel ?? throw new ArgumentNullException(nameof(detailsViewModel));
        }
    }
}
