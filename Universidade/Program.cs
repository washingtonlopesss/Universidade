using System;
using System.Collections.Generic;
using Universidade.Models; // Certifique-se de importar a classe Aluno corretamente

namespace Universidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listAluno = new List<Aluno>(); // Movido para fora do loop

            while (true)
            {
                Console.WriteLine("[1] - Adicionar Novo aluno:");
                Console.WriteLine("[2] - Exibir Alunos");
                Console.WriteLine("[3] - Excluir Aluno");
                int valorDigitado = int.Parse(Console.ReadLine());

                switch (valorDigitado)
                {
                    case 1:                        
                        Console.WriteLine("Nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("RA:");
                        string ra = Console.ReadLine();
                        Console.WriteLine("Deseja adicionar matricula? S/N");
                        string resposta = Console.ReadLine();
                        string nomeCurso = "";
                        if (resposta == "N" || resposta == "n")
                        {
                            Aluno aluno = new Aluno(nome, ra);
                            listAluno.Add(aluno);
                        }
                        else
                        {
                            Console.WriteLine("Curso:");
                            nomeCurso = Console.ReadLine();
                            
                        }
                        Curso curso = new Curso(nomeCurso);
                        break;
                    case 2:
                        Console.WriteLine("Lista de Alunos:");
                        foreach (Aluno alun in listAluno)
                        {
                            Console.Write($"Nome: {alun.Nome} \nRA: {alun.RA} \nCurso: ");
                            Console.WriteLine(curso.Nome);
                        }
                        break;
                }
            }
        }
    }
}
