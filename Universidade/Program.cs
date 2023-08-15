using System;
using System.Collections.Generic;
using Universidade.Models;

namespace Universidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listAluno = new List<Aluno>();
            List<Curso> listCurso = new List<Curso>();
            List<Disciplina> listDisciplina = new List<Disciplina>();

            var loopControl = true;

            while (loopControl)
            {
                Console.WriteLine("1. Adicionar aluno:");
                Console.WriteLine("2. Exibir todos alunos:");

                int valueTyped = int.Parse(Console.ReadLine());

                switch (valueTyped)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("Digite o nome: ");
                        string name = Console.ReadLine();

                        Console.Write("Digite o RA: ");
                        string ra = Console.ReadLine();

                        var aluno = new Aluno(name, ra);
                        listAluno.Add(aluno);

                        Console.Write("Matricular em algum curso? S/N ");
                        string registration = Console.ReadLine();

                        if (registration == "s" || registration == "S")
                        {
                            Console.Write("Digite o nome do curso: ");
                            string nameCorse = Console.ReadLine();
                            var curso = new Curso(nameCorse);
                            listCurso.Add(curso);
                        } 
                        else
                        {
                            var curso = new Curso("Aluno sem matrícula");
                            listCurso.Add(curso);
                        }

                        Console.WriteLine("Aluno registrado!"); 
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();

                        for (int i = 0; i < listAluno.Count; i++)
                        {
                            Console.WriteLine(listAluno[i].Nome + " " + listAluno[i].RA + " " + listCurso[i].Nome);
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }
            }
        }
    }
}