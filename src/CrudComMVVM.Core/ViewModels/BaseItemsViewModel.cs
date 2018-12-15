using System.Collections.Generic;

namespace CrudComMVVM.Core.ViewModels
{
    public class BaseItemsViewModel<TEntity> : BaseViewModel
        where TEntity : BaseEntity, new()
    {
        #region Properties

        public ICollection<TEntity> Items { get; } = new List<TEntity>();

        #endregion
    }
}
