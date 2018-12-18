using CrudComMVVM.Business.Entities;
using CrudComMVVM.Core;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace CrudComMVVM.DesktopWFP.ViewModels
{
    public class PessoaDetailsViewModel : BaseDetailsViewModel<Pessoa>
    {
        #region Local Variables

        private ICommand _saveCommand;

        #endregion

        #region Properties

        public IList<Pessoa> Items { get; set; }

        #endregion

        #region Public Methods

        public bool CanSave()
        {
            return DetailsItem != null && DetailsItem.HasChanged;
        }

        public void Save()
        {
            if (Items.Any(f => f.Id == DetailsItem.Id))
            {
                var item = Items.Single(f => f.Id == DetailsItem.Id);
                item = DetailsItem;
            }
            else
            {
                Items.Add(DetailsItem);
            }
        }

        #endregion
    }
}
