using System.Net.Http.Headers;

namespace _5aListaAcadDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            /*
            int[,] mat = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite os valores da coluna 0: ");
                mat[i, 0] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                mat[i, 1] = mat[i, 0] + 10;
                mat[i, 2] = mat[i, 0] * 2;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            */



            //EXERCÍCIO 2
            /*
            int[,] mat = new int[3, 3];
            int auxI = 0, auxJ = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    auxI = auxI + mat[i, j];
                    auxJ = auxJ + mat[j, i];
                }
                Console.WriteLine("Soma da linha " + (i + 1) + ": " + auxI);
                Console.WriteLine("Soma da coluna " + (i + 1) + ": " + auxJ);
                auxI = 0;
                auxJ = 0;

            }
            */



            //EXERCÍCIO 3
            /*
            int[,] mat = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        Console.Write("\n" + mat[i, j] + " " + "\n");
                    }
                }
            }
            */



            //EXERCÍCIO 4
            /*
            int[,] mat = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zero = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mat[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                    if (mat[i, j] > 0)
                    {
                        positivos++;
                    }
                    else if (mat[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        zero++;
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Ímpares: " + impares);
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Zeros: " + zero);
            */



            //EXERCÍCIO 5
            /*
            int[,] mat1 = new int[2, 3];
            int[,] mat2 = new int[2, 3];
            int[,] mat3 = new int[2, 3];

            //Leitura da primeira matriz
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz 1: ");
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Leitura da segunda matriz
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz 2: ");
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Soma da primeira e segunda matriz
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            //Impressão da soma
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + (i + 1) + "," + (j + 1) + "] = " + mat3[i, j] + " ");
                }
                Console.WriteLine();
            }
            */



            //EXERCÍCIO 6
            /*
            int[,] mat = new int[4, 4];
            Random n = new Random();
            int maior = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mat[i, j] = n.Next(0, 10);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + (i + 1) + "," + (j + 1) + "]" + "= " + mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Maior valor apurado: " + maior);
            */



            //EXERCÍCIO 7
            /*
            int[,] mat1 = new int[3, 3];
            int[,] mat2 = new int[3, 3];
            int[,] mat3 = new int[3, 3];

            //Leitura da primeira matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz 1: ");
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Leitura da segunda matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz 2: ");
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Subtração da primeira e segunda matriz (A - B)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat3[i, j] = mat1[i, j] - mat2[i, j];
                }
            }
            //Impressão da subtração
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + (i + 1) + "," + (j + 1) + "] = " + mat3[i, j] + " ");
                }
                Console.WriteLine();
            }
            */



            //EXERCÍCIO 8
            /*
            int[,] mat = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
            */



            //EXERCÍCIO 9
            /*
            int[,] mat = new int[3, 3];
            int n;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.Write("Digite inteiro um número qualquer: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (n == mat[i, j])
                    {
                        Console.WriteLine("O número está na matriz.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O valor não está na matriz.");
                    }
                }
            }
            */



            //EXERCÍCIO 10
            /*

            int[,] mat1 = new int[4, 4];
            int[,] mat2 = new int[4, 4];
            int media2 = 0, media1 = 0, auxCimaMedia = 0, auxMedia = 0, auxBaixoMedia = 0;

            //Leitura da primeira matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz 1: ");
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Leitura da segunda matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o valor " + (i + 1) + " - " + (j + 1) + " da matriz 2: ");
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Cálculo média
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    media1 += mat1[i, j];
                    media2 += mat2[i, j];
                }
            }
            media1 = media1 / 16;
            media2 = media2 / 16;

            //Valores maiores que a média
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mat1[i, j] > media1)
                    {
                        auxCimaMedia++;
                    }
                    else if (mat1[i, j] == media1)
                    {
                        auxMedia++;
                    }
                    else
                    {
                        auxBaixoMedia++;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mat2[i, j] > media2)
                    {
                        auxCimaMedia++;
                    }
                    else if (mat2[i, j] == media2)
                    {
                        auxMedia++;
                    }
                    else
                    {
                        auxBaixoMedia++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de valores abaixo da média: " + auxBaixoMedia);
            Console.WriteLine("Quantidade de valores na média: " + auxMedia);
            Console.WriteLine("Quantidade de valores acima da média: " + auxCimaMedia);
            Console.WriteLine("Media 1: " + media1);
            Console.WriteLine("Media 2: " + media2);
            */



            //EXERCÍCIO 11
            /**/













        }
    }
}