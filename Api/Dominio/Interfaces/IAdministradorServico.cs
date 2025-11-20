using minimal_api.Dominio.DTOs;
using Minimalapi.Dominio.Entidades;
using Minimalapi.Dtos;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTOs loginDTO);
    Administrador Incluir(Administrador administrador);
    List<Administrador> Todos(int? pagina);
    Administrador? BuscaPorId(int id);
}