using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CadastroDomain.Entities;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels;
public class PessoaViewModel
{
    public IEnumerable<Pessoa> Pessoas { get; set; }
}
