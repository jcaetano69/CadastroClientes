using CadastroDomain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDomain.Validations;
public class EnderecoValidation : AbstractValidator<Endereco>
{
    public EnderecoValidation()
    {
        RuleFor(x => x.Rua)
           .MaximumLength(255);
        RuleFor(x => x.Estado)
           .MaximumLength(255);
        RuleFor(x => x.Cidade)
           .MaximumLength(255);


    }
}
