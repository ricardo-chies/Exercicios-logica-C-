using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex07
    {
        public static void Main(string[] args)
        {
            //Exercício 7.0

            Console.WriteLine("Iniciando o Programa");

            Console.WriteLine("Digite seu nome de usuário:");
            string nomeUsuario = Console.ReadLine();
            NomeUsuario(nomeUsuario);

            Console.WriteLine("Faremos a soma de dois números:");
            Console.WriteLine("Digite o primeiro número:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            float n2 = float.Parse(Console.ReadLine());

            float resultadoSoma = Soma(n1, n2);
            Console.WriteLine("O resultado da soma de {0} + {1} é {2}", n1, n2, resultadoSoma);

            Console.WriteLine("Vamos descobrir se essa soma é um número impar ou par:");
            Console.ReadLine();
            float resultadoParOuImpar = ParOuImpar(resultadoSoma);
            string txtParOuImpar = TxtParOuImpar(resultadoParOuImpar);
            Console.WriteLine("{0} é um número {1}!", resultadoSoma, txtParOuImpar);

            Console.WriteLine("Vamos descobrir qual é a média dos números digitados:");
            Console.ReadLine();
            float resultadoMedia = Media(n1, n2);
            Console.WriteLine("O resultado da média de {0} + {1} é {2}", n1, n2, resultadoMedia);
            Console.ReadLine();



        }

        public static string NomeUsuario(string nomeUsuario)
        {
            Console.WriteLine("Bem vindo " + nomeUsuario);
            Console.ReadLine();
            return nomeUsuario;
        }

        public static float Soma(float n1, float n2)
        {
            float resultadoSoma = n1 + n2;
            return resultadoSoma;
        }

        public static float Media(float n1, float n2)
        {
            float media = (n1 + n2) / 2;
            return media;
        }

        public static float ParOuImpar(float resultadoSoma)
        {

            if (resultadoSoma % 2 == 1)
            {
                int resultadoParOuImpar = 1;
                return resultadoParOuImpar;
            }
            else
            {
                int resultadoParOuImpar = 0;
                return resultadoParOuImpar;
            }

        }

        public static string TxtParOuImpar(float txt)
        {
            if (txt == 1)
            {
                string impar = "impar";
                return impar;
            }
            else
            {
                string par = "par";
                return par;
            }
        }
    }
}