using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista10
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("digite o vetor");
            int V = int.Parse(Console.ReadLine());
            float[] num = new float[V];
            for (int i = 0; i < V; i++)
            {
                Console.WriteLine("digite o numero");
                num[i] = float.Parse(Console.ReadLine());
            }
            float me = num[0];
            float ma = num[0];
            float soma = num[0];
            for (int i = 1; i < V; i++)
            {
                if (num[i] < me)
                    me = num[i];

                if (num[i] > ma)
                    ma = num[i];

                soma += num[i];
            }
            float med = soma / V;
            Console.WriteLine("menor número: " + me);
            Console.WriteLine("maior número: " + ma);
            Console.WriteLine("media: " + med);
        }
        Console.ReadKey();

        public static void Exercicio2()
        {
            Console.Write("digite o tamanho do vetor");
            int V = int.Parse(Console.ReadLine());
            float[] num = new float[V];
            for (int i = 0; i < V; i++)
            {
                Console.Write("digite o número");
                num[i] = float.Parse(Console.ReadLine());
            }
            float me = num[0];
            float maior = num[0];
            float soma = num[0];
            for (int i = 1; i < V; i++)
            {
                if (num[i] < me)
                    me = num[i];

                if (num[i] > maior)
                    maior = num[i];

                soma += num[i];
            }
            float med = soma / V;
            Console.WriteLine("média:" + med);
            for (int i = 0; i < V; i++)
            {

                if (num[i] >= med)
                {
                    Console.WriteLine("os numeros mairoes que a media: " + num[i]);

                }
            }
            for (int i = 0; i < V; i++)
            {
                if (num[i] <= med)
                {
                    Console.WriteLine("os numeros menores que a media: " + num[i]);


                }
            }
        }
        Console.ReadKey();

        public static void Exercicio3()
        {
            int[] num;
            int tam, soma = 0, media;
            Console.WriteLine("digite o tamanho");
            tam = int.Parse(Console.ReadLine());
            num = new int[tam];
            Random rand = new Random();
            for (int i = 0; i < tam; i++)
            {
                num[i] = rand.Next(1, 10000);

            }
            for (int i = 0; i < tam; i++)
            {
                soma += num[i];
            }
            media = soma / tam;
            for (int i = 0; i < tam; i++)
            {
                if (num[i] >= media)
                {
                    Console.WriteLine("os numeros maiores ou iguais a media são " + num[i]);
                }
            }
            Console.WriteLine("media= " + media);

        }
        Console.ReadKey();

        public static void Exercicio4()
        {
            string[] n;
            int tamanho = int.Parse(Console.ReadLine());
            n = new string[tamanho];
            for (int i = 0; i <= 0; i++)
            {

                Console.WriteLine("digite as assinaturas:");
                n[i] = Console.ReadLine();
            }
            for (int i = 0; i < tamanho; i--)
            {
                Console.WriteLine("nomes: " + n[i]);
            }

        }
        Console.ReadKey();

        public static void Exercicio5()
        {


        }


        static void Main(string[] args)
        {
            int opção;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("digite 1 para exercicio 1");
                Console.WriteLine("digite 2 para exercicio 2");
                Console.WriteLine("digite 3 para exercicio 3");
                Console.WriteLine("digite 4 para exercicio 4");

                opção = int.Parse(Console.ReadLine());

                switch (opção)
                {
                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;


                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    case 5:
                        Exercicio5();
                        break;
                }




            } while (opção != 0);
        }
    }
}


