using System;
using System.Runtime.InteropServices;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Daniel é um agricultor e precisa de um programa que ao digitar o numero inicial e final, o programa mostra
                repetidamente todos os números na tela
            */
            Console.WriteLine("Digite o número inicial: ");
            int numInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número final: ");
            int numFinal = Convert.ToInt32(Console.ReadLine());
            int indice = numInicial;
            while(indice <= numFinal) {
                Console.WriteLine(indice);
                indice++;
            }

            for(int i = numInicial; i <= numFinal; i++) {
                Console.WriteLine(i);
            }

            int[] itens = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach(int item in itens) {
                Console.WriteLine("Teste:" + item);
            }
            return;













            int caseSwitch = 1;
            // Utilizar o SWITCH quando se sabe o valor especifico para executar o processo.
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case.");
                    break;
            }

            Console.WriteLine("Digite o primeiro número: ");
            var numeroUm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int numeroDois = Convert.ToInt32(Console.ReadLine());
            var soma = numeroUm * numeroDois;

            Console.WriteLine($"Digite o número permiado?");
            int resultado = Convert.ToInt32(Console.ReadLine());

            if (soma == resultado || resultado == 1 || resultado == 10 || (resultado >= 100 && resultado <= 200))
            {
                Console.WriteLine($"Parabéns você acertou o resultado: {soma}");
            }
            else if (resultado == 20)
            {
                Console.WriteLine("Você acertou a opção extraordinária, incrivel!");
            }
            else
            {
                Console.WriteLine($"O resultado é {soma}, você errou, tente novamente na próxima.");
            }

            //Console.WriteLine($"A soma das variáveis é: {soma}");
            //Console.WriteLine("A soma das variáveis é: " + soma);
            //Console.WriteLine("A soma das variáveis é: {0}, {1}", soma, soma);
        }
    }
}