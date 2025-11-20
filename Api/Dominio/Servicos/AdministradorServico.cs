using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.DTOs;
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

    public Administrador Incluir(Administrador administrador)
    {

        _contexto.administradores.Add(administrador);
        _contexto.SaveChanges();
        return administrador;
    }

    public Administrador? Login(LoginDTOs loginDTo)
    {
        var administrador = _contexto.administradores.Where(a => a.Email == loginDTo.Email && a.Senha == loginDTo.Senha).FirstOrDefault();
        return administrador;
    }

    public List<Administrador> Todos(int? pagina)
    {
        var query = _contexto.administradores.AsQueryable();
        int itensPorPagina = 10;

        if (pagina != null)
        {
            query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);
        }

        return query.ToList();
    }
    
    public Administrador? BuscaPorId(int id)
    {
        return _contexto.administradores.Where(a => a.Id == id).FirstOrDefault();
    }
}