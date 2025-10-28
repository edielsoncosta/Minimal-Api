using Minimalapi.Dominio.Entidades;
using Minimalapi.Dtos;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTOs loginDTO);
}