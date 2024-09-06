using AppFakeStore.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using AppFakeStore.Utils;
using System.Net.Http.Json;

namespace AppFakeStore.Services
{
    public class UsuariosService : IUsuariosService
    {
        HttpClient client;

        private static JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public UsuariosService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(Constants.ApiDataServer)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Usuario>> GetUsuariosAsync()
        {
            try
            {
                var response = await client.GetAsync(Constants.UsersEndpoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<IEnumerable<Usuario>>(options);
                }
                else
                {
                    // Puedes registrar el error o manejarlo aquí
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return new List<Usuario>();
                }
            }
            catch (Exception ex)
            {
                // Registra o maneja la excepción aquí
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Usuario>();
            }
        }
    }
}
