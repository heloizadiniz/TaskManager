using System;
using System.Collections.Generic;

namespace TaskManager
{
    public class TaskService
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa(string descricao)
        {
            if (!string.IsNullOrWhiteSpace(descricao))
            {
                tarefas.Add(new Tarefa(descricao));
                Console.WriteLine("\n✅ Tarefa adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("\n❌ Tarefa inválida!");
            }
        }

        public void ListarTarefas()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("       LISTA DE TAREFAS");
            Console.WriteLine("==============================");

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i].Descricao}");
                }
            }

            Console.WriteLine("==============================");
        }

        public void RemoverTarefa(int index)
        {
            index--;

            if (index >= 0 && index < tarefas.Count)
            {
                tarefas.RemoveAt(index);
                Console.WriteLine("\n🗑️ Tarefa removida!");
            }
            else
            {
                Console.WriteLine("\n❌ Número inválido!");
            }
        }
    }
}