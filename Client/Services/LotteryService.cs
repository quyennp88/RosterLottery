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
    internal class LotteryService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        internal LotteryService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7266/");
        }

        internal async Task<bool?> SubmitLottery(UserLottery userLottery)
        {
            HttpResponseMessage response = await _client.PostAsync("/Lottery/SubmitLottery", userLottery, new JsonMediaTypeFormatter());

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
        internal async Task<Lottery> GetOpenLottery()
        {
            HttpResponseMessage response = await _client.GetAsync("/Lottery/GetOpenLottery");

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var lottery = System.Text.Json.JsonSerializer.Deserialize<Lottery>(result, options);
                return lottery;
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }
        
        internal async Task<List<UserLottery>> GetHistoryLotteries(int userID)
        {
            HttpResponseMessage response = await _client.GetAsync("/Lottery/GetHistoryLotteries?userID=" + userID);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var lottery = System.Text.Json.JsonSerializer.Deserialize<List<UserLottery>>(result, options);
                return lottery;
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }
    }
}
