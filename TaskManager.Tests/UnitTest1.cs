using System.Threading.Tasks;
using Xunit;
using TaskManager;

namespace TaskManager.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task DeveRetornarFraseMotivacional()
        {
            MotivacaoService service = new MotivacaoService();

            string frase = await service.ObterFrase();

            Assert.False(string.IsNullOrWhiteSpace(frase));
        }
    }
}