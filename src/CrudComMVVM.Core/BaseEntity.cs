using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrudComMVVM.Core
{
    public class BaseEntity
    {
        #region Properties

        public ICollection<string> ChangedProperties { get; } = new List<string>();

        #endregion

        #region Protected Methods

        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (!ChangedProperties.Contains(propertyName))
                ChangedProperties.Add(propertyName);
        }

        #endregion
    }

    public class BaseEntity<T> : BaseEntity
        where T : BaseModel, new()
    {
        #region Properties
        
        public T Model { get; } = new T();

        #endregion
    }
}
