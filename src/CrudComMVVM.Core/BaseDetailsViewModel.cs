namespace CrudComMVVM.Core
{
    public class BaseDetailsViewModel<TEntity> : BaseViewModel<TEntity>
        where TEntity : BaseEntity, new()
    {
        #region Local Variables

        private TEntity _detailsItem;

        #endregion

        #region Properties

        public TEntity DetailsItem
        {
            get { return _detailsItem; }
            set { SetField(ref _detailsItem, value); }
        }

        #endregion
    }
}
