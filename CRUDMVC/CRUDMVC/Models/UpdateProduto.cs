using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRUDMVC.Models
{
    public class UpdateProduto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;
    }
}
