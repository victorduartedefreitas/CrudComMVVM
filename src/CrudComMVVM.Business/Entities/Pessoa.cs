using CrudComMVVM.Core;
using System.Collections.Generic;

namespace CrudComMVVM.Business.Entities
{
    public class Pessoa : BaseEntity<Data.Models.Pessoa>
    {
        #region Properties

        public int Id
        {
            get => Model.Id;
            set
            {
                if (Model.Id != value)
                {
                    Model.Id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        public string Nome
        {
            get => Model.Nome;
            set
            {
                if (!EqualityComparer<string>.Default.Equals(Model.Nome, value))
                {
                    Model.Nome = value;
                    RaisePropertyChanged("Nome");
                }
            }
        }

        public string Telefone
        {
            get => Model.Telefone;
            set
            {
                if (!EqualityComparer<string>.Default.Equals(Model.Telefone, value))
                {
                    Model.Telefone = value;
                    RaisePropertyChanged("Telefone");
                }
            }
        }

        #endregion
    }
}
