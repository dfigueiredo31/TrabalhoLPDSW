using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAvaliacao.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titlo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public float PesoAvaliacao { get; set; }
    }
}
