using System;
using System.Collections.Generic;
using System.Text;

namespace CrudComMVVM.Core.Views
{
    public class BaseDetailsView<TEntity> : IDetailsView<TEntity>
        where TEntity : BaseEntity, new()
    {
    }
}
