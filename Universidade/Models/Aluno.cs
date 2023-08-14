using Universidade;

namespace Universidade.Models
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public string NomeCurso { get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, string ra) 
        { 
            Nome = nome;
            RA = ra;
        }

        public Aluno(string nome, string ra, string curso) : this(nome, ra) 
        {
            NomeCurso = curso;
        }


    }
}
