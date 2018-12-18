using CrudComMVVM.Core;
using System.Windows.Input;
using System.Linq;
using CrudComMVVM.Business.Entities;

namespace CrudComMVVM.DesktopWFP.ViewModels
{
    public class PessoaViewModel : BaseItemsViewModel<Pessoa>
    {
        #region Local Variables

        private ICommand _deleteCommand;
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

        public bool CanNew()
        {
            return true;
        }

        public void New()
        {
            //DetailsItem = new Business.Entities.Pessoa();
        }

        #endregion
    }
}
