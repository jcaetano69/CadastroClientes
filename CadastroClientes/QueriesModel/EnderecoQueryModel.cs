using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.QueriesModel;
public class EnderecoQueryModel : QueryModel
{
    public string Rua { get; set; }
    public int Número { get; set; }
    public int Cep { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
}
