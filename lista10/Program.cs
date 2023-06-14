using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.WriteLine("                  Menu           ");
            Console.WriteLine("digite o numero do exercio para iniciar");
            Console.WriteLine("              Exercicio 1"  );
            Console.WriteLine("              Exercicio 2");
            Console.WriteLine("              Exercicio 3");
            Console.WriteLine("              Exercicio 4");
            Console.WriteLine("              Exercicio 5");
            Console.WriteLine("        Digite 0 para encerrar");
            menu=int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        Console.Write("Digite o tamanho do vetor: ");
                        int A = int.Parse(Console.ReadLine());

                        float[] vetor = new float[A];

                        for (int i = 0; i < A; i++)
                        {
                            Console.Write("Digite um número: ");
                            vetor[i] = float.Parse(Console.ReadLine());
                        }

                        float menor = vetor[0];
                        float maior = vetor[0];
                        float soma = vetor[0];

                        for (int i = 1; i < A; i++)
                        {
                            if (vetor[i] < menor)
                                menor = vetor[i];

                            if (vetor[i] > maior)
                                maior = vetor[i];

                            soma += vetor[i];
                        }

                        float media = soma / A;

                        Console.WriteLine("Menor número: " + menor);
                        Console.WriteLine("Maior número: " + maior);
                        Console.WriteLine("Média aritmética: " + media);
                    }
                    break;
                case 2:
                    {
                        Console.Write("Digite o tamanho do vetor: ");
                        int N = int.Parse(Console.ReadLine());

                        float[] vetor = new float[N];

                        for (int i = 0; i < N; i++)
                        {
                            Console.Write("Digite um número: ");
                            vetor[i] = float.Parse(Console.ReadLine());
                        }

                        float soma = 0;

                        for (int i = 0; i < N; i++)
                        {
                            soma += vetor[i];
                        }

                        float media = soma / N;

                        Console.WriteLine("Números maiores ou iguais à média:");

                        for (int i = 0; i < N; i++)
                        {
                            if (vetor[i] >= media)
                                Console.WriteLine(vetor[i]);
                        }
                    }
                    break;
                case 3:
                    {
                        Console.Write("Digite o tamanho do vetor: ");
                        int N = int.Parse(Console.ReadLine());

                        float[] vetor = new float[N];
                        Random random = new Random();

                        for (int i = 0; i < N; i++)
                        {
                            vetor[i] = (float)random.NextDouble() * 100;
                        }

                        float soma = 0;

                        for (int i = 0; i < N; i++)
                        {
                            soma += vetor[i];
                        }

                        float media = soma / N;

                        Console.WriteLine("Números gerados maiores ou iguais à média:");

                        for (int i = 0; i < N; i++)
                        {
                            if (vetor[i] >= media)
                                Console.WriteLine(vetor[i]);
                        }
                    }
                    break;
                case 4:
                    {
                        Console.Write("Digite a quantidade de nomes: ");
                        int N = int.Parse(Console.ReadLine());

                        List<string> nomes = new List<string>();

                        for (int i = 0; i < N; i++)
                        {
                            Console.Write("Digite um nome: ");
                            string nome = Console.ReadLine();
                            nomes.Add(nome);
                        }

                        Console.WriteLine("Nomes (do último para o primeiro):");

                        for (int i = N - 1; i >= 0; i--)
                        {
                            Console.WriteLine(nomes[i]);
                        }
                    }
                    break;
                case 5:
                    {
                        Console.Write("Digite o tamanho do vetor: ");
                        int N = int.Parse(Console.ReadLine());

                        int[] vetor = new int[N];
                        Random random = new Random();

                        int pares = 0;
                        int impares = 0;

                        for (int i = 0; i < N; i++)
                        {
                            vetor[i] = random.Next(1, 101);

                            if (vetor[i] % 2 == 0)
                                pares++;
                            else
                                impares++;
                        }

                        Console.WriteLine("Quantidade de números pares: " + pares);
                        Console.WriteLine("Quantidade de números ímpares: " + impares);
                    }
                    break;
                case 0:
                    { Console.WriteLine("Obrigado :)"); }
                    break;
            }

        }
    }
}
