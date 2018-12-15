using System;
using System.Collections.Generic;
using System.Text;

namespace CrudComMVVM.Core.Views
{
    public interface IDetailsView<TEntity>
        where TEntity : BaseEntity, new()
    {
    }
}
