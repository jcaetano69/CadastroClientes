﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDomain.Entities;
public class Pessoa : AuditableEntity
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public EGenero Genero { get; set; }
    public string Celular { get; set; }
    public string Observações { get; set; }
    public Endereco Endereco { get; set; }

}