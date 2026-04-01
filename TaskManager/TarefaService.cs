using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;


namespace TaskManager
{
    public class TaskService
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private string caminhoArquivo = "tarefas.json";

        public TaskService()
        {
            CarregarDoArquivo();
        }

        public void AdicionarTarefa(string descricao)
        {
            if (!string.IsNullOrWhiteSpace(descricao))
            {
                tarefas.Add(new Tarefa(descricao));
                SalvarEmArquivo();
                Console.WriteLine("Tarefa adicionada!");
            }
            else
            {
                Console.WriteLine("Tarefa inválida!");
            }
        }

        public void ListarTarefas()
        {
            Console.WriteLine("\n--- Lista de Tarefas ---");

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            for (int i = 0; i < tarefas.Count; i++)
            {
                string status = tarefas[i].Concluida ? "[X]" : "[ ]";
                Console.WriteLine($"{i} - {status} {tarefas[i].Descricao}");
            }
        }

        public void RemoverTarefa(int index)
        {
            if (index >= 0 && index < tarefas.Count)
            {
                tarefas.RemoveAt(index);
                SalvarEmArquivo();
                Console.WriteLine("Tarefa removida!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        private void SalvarEmArquivo()
        {
            string json = JsonSerializer.Serialize(tarefas);
            File.WriteAllText(caminhoArquivo, json);
        }

        private void CarregarDoArquivo()
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                tarefas = JsonSerializer.Deserialize<List<Tarefa>>(json) ?? new List<Tarefa>();
            }

        }
        public int QuantidadeTarefas()
        {
            return tarefas.Count;
        }

    }


}