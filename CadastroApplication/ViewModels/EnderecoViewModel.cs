using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CadastroDomain.Entities;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels;
public class EnderecoViewModel
{
    public IEnumerable<Endereco> Enderecos { get; set; }
}
