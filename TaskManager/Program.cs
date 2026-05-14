using System;
using System.Threading.Tasks;
using TaskManager;

class Program
{
    static async Task Main()
    {
        TaskService service = new TaskService();
        MotivacaoService motivacao = new MotivacaoService();

        try
        {
            string frase = await motivacao.ObterFrase();

            Console.WriteLine("\n===== FRASE MOTIVACIONAL =====");
            Console.WriteLine(frase);
        }
        catch
        {
            Console.WriteLine("Não foi possível carregar a frase.");
        }

        while (true)
        {
            Console.WriteLine("\n==== GERENCIADOR DE TAREFAS ====");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Remover tarefa");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    string tarefa = Console.ReadLine();
                    service.AdicionarTarefa(tarefa);
                    break;

                case "2":
                    service.ListarTarefas();
                    break;

                case "3":
                    Console.Write("Digite o número da tarefa: ");

                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        service.RemoverTarefa(index);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida!");
                    }

                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}