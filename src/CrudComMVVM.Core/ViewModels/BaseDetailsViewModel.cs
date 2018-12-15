namespace CrudComMVVM.Core.ViewModels
{
    public class BaseDetailsViewModel<TEntity> : BaseViewModel
        where TEntity : BaseEntity, new()
    {
        #region Properties

        public TEntity CurrentItem { get; }

        #endregion
    }
}
