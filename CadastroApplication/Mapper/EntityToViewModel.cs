using AutoMapper;
using Cadastro.Application.ViewModels;
using CadastroDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Mapper;
public class EntityToViewModel : Profile
{
    public EntityToViewModel()
    {
        CreateMap<Pessoa, PessoaViewModel>();
        CreateMap<Endereco, EnderecoViewModel>();
    }
}
