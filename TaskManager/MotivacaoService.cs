using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TaskManager
{
    public class MotivacaoService
    {
        public async Task<string> ObterFrase()
        {
            using HttpClient client = new HttpClient();

            string url = "https://zenquotes.io/api/random";

            string response = await client.GetStringAsync(url);

            using JsonDocument doc = JsonDocument.Parse(response);

            string? frase = doc.RootElement[0]
      .GetProperty("q")
      .GetString();

            return frase ?? "Sem frase";
        }
    }
}