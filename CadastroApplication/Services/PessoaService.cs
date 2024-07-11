using Cadastro.Application.Interfaces;
using Cadastro.Application.ViewModels;
using Cadastro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services;
class PessoaService : IPessoaService
{
    public IPessoaRepository _pessoaRepository;
    public PessoaService(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }
    public PessoaViewModel GetPessoas()
    {
        return new PessoaViewModel()
        {
            Pessoas = _pessoaRepository.GetPessoas()
        };
    }
}
