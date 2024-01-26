using System;
using System.Runtime.InteropServices;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Aluno() {Nome = "Gilmar", Matricula = "004", Notas = new List<double>() {6, 6, 9}}.Salvar();
            //new Aluno() {Nome = "Raul", Matricula = "005", Notas = new List<double>() {5, 6, 3}}.Salvar();
            //new Aluno() {Nome = "Marina", Matricula = "006", Notas = new List<double>() {9, 9, 10}}.Salvar();
            var alunosBanco = Aluno.Todos();
            foreach(var item in alunosBanco) 
            {
                //item.Notas.Add(10);
                //item.Salvar();
                //item.Apagar();
                //break;
                Console.WriteLine($"Nome: {item.Nome}, Matricula: {item.Matricula}, Notas: {string.Join(",",item.Notas.ToArray())}, "
                + $"Média: {item.CalcularMedia()}, Resultado: {item.Situacao()}");
            }

            return;


            /*
                Valquiria é a diretora da escola Mundo Melhor. Ela precisa de um programa que armazene alunos com suas matriculas
                e notas em uma tabela, no final ela tem a necessidade de saber se o aluno foi aprovado ou não. Faça um programa 
                para resolver a questão da Valquiria.
            */
            List<Aluno> alunos = new List<Aluno>();
            while(true) {
                var aluno = new Aluno(); //{ Nome = "Danilo", Matricula = "001" };
                Console.WriteLine("Digite o nome do Aluno:");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a matricula do aluno:");
                aluno.Matricula = Console.ReadLine();
                Console.WriteLine("Digite a Nota 1:");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Digite a Nota 2:");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                // var media = (nota1 + nota2) / 2;
                // String res = media >= 5.0 ? "Aprovado" : "Reprovado";
                // alunos.Add(new {Nome = nome, Nota1 = nota1, Nota2 = nota2, Media = media, Resultado = res});
                alunos.Add(aluno);
                Console.WriteLine("Deseja inserir a nota de outro aluno? Digite [S]im ou [N]ão:");
                
                var resposta = Console.ReadLine();
                if (resposta == "N") {
                    break;
                }
            }

            foreach(var item in alunos) {
                Console.WriteLine($"Nome: {item.Nome}, Matricula: {item.Matricula}, Notas: {string.Join(",",item.Notas.ToArray())}, "
                + $"Média: {item.CalcularMedia()}, Resultado: {item.Situacao()}");
            }

            return;
            List<dynamic> alunos2 = new List<dynamic>();
            alunos2.Add(new {
                Nome = "Danilo", Matricula = "001", Notas = "10, 8, 7"
            });
            alunos2.Add(new {
                Nome = "Estela", Matricula = "001", Notas = "10, 8, 7"
            });

            foreach(var aluno in alunos2) {
                Console.WriteLine($"Nome: {aluno.Nome}, Matricula: {aluno.Matricula}, Nota: {aluno.Notas}");
            }
            



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

            int[][] itensMatriz = new int[][]{[1,3,4,5],[2,3,4,5]};




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