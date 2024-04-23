using System.Numerics;
using System.Text.Json;
using Client.Models;
using static System.Windows.Forms.Design.AxImporter;
using RoosterLottery.Client.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Formatting;
using System.Net.Http;

namespace Client.Services
{
    internal class UserService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        internal UserService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7266/");
        }

        internal async Task<User> Login(User user)
        {

            HttpResponseMessage response = await _client.PostAsync("/User/Login", user, new JsonMediaTypeFormatter());

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                User result = System.Text.Json.JsonSerializer.Deserialize<User>(responseBody, options);

                return result;
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }
        internal async Task<bool?> Register(User user)
        {
            HttpResponseMessage response = await _client.PostAsync("/User/Register", user, new JsonMediaTypeFormatter());

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return System.Boolean.Parse(result);
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }
    }
}
