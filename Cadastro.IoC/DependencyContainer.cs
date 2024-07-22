using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cadastro.Application.Interfaces;
using Cadastro.Application.Services;
using Cadastro.Infra.Data.Repositories;
using System.Threading.Tasks;
using Cadastro.Domain.Interfaces.Repository;

namespace Cadastro.IoC;
public class DependencyContainer
{
    public static void AddServicesInjections(IServiceCollection services) 
    {
        //Services
        services.AddScoped<IPessoaService, PessoaService>();
        //Repositories
        services.AddScoped<IPessoaRepository, PessoaRepository>();
       
    }
}
