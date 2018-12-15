using System;
using System.Collections.Generic;
using System.Text;

namespace CrudComMVVM.Core.Views
{
    public class BaseItemsView<TEntity> : IItemsView<TEntity>
        where TEntity : BaseEntity, new()
    {
    }
}
