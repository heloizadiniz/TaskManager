using TaskManager;
using Xunit;

public class TaskServiceTests
{
    [Fact]
    public void DeveAdicionarTarefa()
    {
        var service = new TaskService();

        int antes = service.QuantidadeTarefas();

        service.AdicionarTarefa("Estudar");

        int depois = service.QuantidadeTarefas();

        Assert.Equal(antes + 1, depois);
    }

    [Fact]
    public void NaoDeveAdicionarTarefaVazia()
    {
        var service = new TaskService();

        int antes = service.QuantidadeTarefas();

        service.AdicionarTarefa("");

        int depois = service.QuantidadeTarefas();

        Assert.Equal(antes, depois);
    }

    [Fact]
    public void RemoverIndiceInvalidoNaoDeveQuebrar()
    {
        var service = new TaskService();

        service.RemoverTarefa(999);

        Assert.True(true);
    }
}
