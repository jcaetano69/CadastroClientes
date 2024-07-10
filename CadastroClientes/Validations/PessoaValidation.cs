using CadastroDomain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDomain.Validations;
public class PessoaValidation : AbstractValidator<Pessoa>
{
    public PessoaValidation()
    {

        RuleFor(x => x.id);

        RuleFor(x => x.Nome)
           .MaximumLength(255);

        RuleFor(x => x.Email)
            .MaximumLength(255);

        RuleFor(x => x.Cpf)
            .MaximumLength(10);

        RuleFor(x => x.Rg)
            .MaximumLength(9);

        RuleFor(x => x.Celular)
            .MaximumLength(14);



    }
}
