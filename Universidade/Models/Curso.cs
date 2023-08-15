using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade.Models
{
    internal class Curso
    {
        public string Nome { get; set; } = "";

        public Curso(string nome)
        {
            Nome = nome;
        }
    }
}
