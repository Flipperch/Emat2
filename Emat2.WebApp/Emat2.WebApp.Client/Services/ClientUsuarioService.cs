using Emat2.WebApp.Client.Models;
using System.Net.Http.Json;

namespace Emat2.WebApp.Client.Services;

public class ClientUsuarioService(HttpClient httpClient) : IUsuarioService
{
    public async Task<UsuarioModel[]> GetUsuariosAsync()
    {
        //return await httpClient.GetFromJsonAsync<UsuarioModel[]>("api/usuarios") ?? Array.Empty<UsuarioModel>();

        return null;
    }

    public async Task<UsuarioModel?> GetUsuarioByIdAsync(string id)
    {
        //return await httpClient.GetFromJsonAsync<UsuarioModel?>($"api/usuarios/{id}");

        return null;
    }

    public async Task<UsuarioModel?> CreateUsuarioAsync(UsuarioModel usuario)
    {
        //var response = await httpClient.PostAsJsonAsync("api/usuarios", usuario);

        //if (response.IsSuccessStatusCode)
        //{
        //    return await response.Content.ReadFromJsonAsync<UsuarioModel>();
        //}

        //return null;

        return null;
    }

    public async Task<bool> UpdateUsuarioAsync(string id, UsuarioModel usuario)
    {
        //var response = await httpClient.PutAsJsonAsync($"api/usuarios/{id}", usuario);
        //return response.IsSuccessStatusCode;

        return false;
    }

    public async Task<bool> DeleteUsuarioAsync(string id)
    {
        //var response = await httpClient.DeleteAsync($"api/usuarios/{id}");
        //return response.IsSuccessStatusCode;
        
        return false;
    }

}
