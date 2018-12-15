using CrudComMVVM.Core;

namespace CrudComMVVM.Data.Models
{
    public class Pessoa : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
