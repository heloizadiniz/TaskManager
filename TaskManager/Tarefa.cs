using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Tarefa
    {
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(string descricao)
        {
            Descricao = descricao;
            Concluida = false;
        }
    }


}
