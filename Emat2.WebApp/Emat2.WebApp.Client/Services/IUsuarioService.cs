using Emat2.WebApp.Client.Models;

namespace Emat2.WebApp.Client.Services;

public interface IUsuarioService
{
    Task<UsuarioModel?> CreateUsuarioAsync(UsuarioModel usuario);
    Task<bool> DeleteUsuarioAsync(string id);
    Task<UsuarioModel?> GetUsuarioByIdAsync(string id);
    Task<UsuarioModel[]> GetUsuariosAsync();
    Task<bool> UpdateUsuarioAsync(string id, UsuarioModel usuario);
}