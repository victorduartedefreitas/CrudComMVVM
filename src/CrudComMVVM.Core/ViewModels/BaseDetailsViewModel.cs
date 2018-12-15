namespace CrudComMVVM.Core.ViewModels
{
    public abstract class BaseDetailsViewModel<TEntity> : BaseViewModel, IDetailsViewModel<TEntity>
        where TEntity : BaseEntity, new()
    {
        #region Properties

        public TEntity CurrentItem { get; set; }

        #endregion
    }
}
