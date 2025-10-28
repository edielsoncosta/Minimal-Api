using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Infraestrutura.Db;
using Minimalapi.Dominio.Entidades;
using Minimalapi.Dtos;
using MinimalApi.Dominio.Interfaces;

namespace MinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{

    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto db)
    {
        _contexto = db;
    }

    public Administrador? Login(LoginDTOs loginDTo)
    {
        var administrador = _contexto.administradores.Where(a => a.Email == loginDTo.Email && a.Senha == loginDTo.Senha).FirstOrDefault();
        return administrador;
    }
}