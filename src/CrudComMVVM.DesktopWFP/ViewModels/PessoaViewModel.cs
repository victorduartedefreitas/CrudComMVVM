using CrudComMVVM.Core;
using System.Windows.Input;
using System.Linq;

namespace CrudComMVVM.DesktopWFP.ViewModels
{
    public class PessoaViewModel : BaseViewModel<Business.Entities.Pessoa>
    {
        #region Local Variables

        private ICommand _deleteCommand;
        private ICommand _saveCommand;
        private ICommand _newCommand;

        #endregion

        #region Properties

        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                    _deleteCommand = new BaseCommand(Delete, CanDelete);

                return _deleteCommand;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new BaseCommand(Save, CanSave);

                return _saveCommand;
            }
        }

        public ICommand NewCommand
        {
            get
            {
                if (_newCommand == null)
                    _newCommand = new BaseCommand(New, CanNew);

                return _newCommand;
            }
        }

        #endregion

        #region Public Methods

        public bool CanDelete()
        {
            return SelectedItem != null;
        }

        public void Delete()
        {
            Items.Remove(SelectedItem);
            SelectedItem = Items.FirstOrDefault();
        }

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

        public bool CanNew()
        {
            return true;
        }

        public void New()
        {
            DetailsItem = new Business.Entities.Pessoa();
        }

        #endregion
    }
}
