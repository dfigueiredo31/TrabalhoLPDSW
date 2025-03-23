using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAvaliacao.Models
{
    internal class Classificacao
    {
        public float Valor { get; set; }
        public int TarefaId { get; set; }
        public int AlunoId { get; set; }

        public Tarefa Tarefa { get; set; }
        public Aluno Aluno { get; set; }
    }
}
