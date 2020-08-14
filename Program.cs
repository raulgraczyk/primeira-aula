using System;

namespace primeira_lista
{
    class Program
    {
        static void Exercicio1()
        {
            //Crie um programa que imprima:
            //a)Os números de 1 a 10 de forma crescente
            System.Console.WriteLine("Crescente:");
            for (int counter = 1; counter < 11; counter++)
            {
                System.Console.WriteLine(counter);
            }
            
            //b)Os números de 1 a 10 de forma descrecente
            System.Console.WriteLine("Descrescente:");
            for (int counter = 10; counter > 0; counter--)
            {
                System.Console.WriteLine(counter);
            }

            //c)Os números de 1 a 10 de forma crescente, mas apenas aqueles
            //que forem par.
            System.Console.WriteLine("Crescente apenas par:");
            for (int counter = 1; counter < 11; counter++)
            {
                if(counter % 2 == 0)
                {
                    System.Console.WriteLine(counter);
                }
            }
        }

        static void Exercicio2()
        {
            //Imprimir a soma dos números inteiros de 1 a 100.
            var sum = 0;
            for (int counter = 1; counter < 101; counter++)
            {
                sum += counter;
            }
            System.Console.WriteLine($"A soma é {sum}");
        }

        static void Exercicio3()
        {
            //Imprimir todo os números ímpares menores de 200.
            System.Console.WriteLine("Números ímpares menores que 200:");
            for (int counter = 1; counter < 201; counter++)
            {
                if((counter % 2) != 0)
                {
                    System.Console.WriteLine(counter);
                }
            }

        }

        static void Exercicio4()
        {
            //Calcular a média de idade de uma turma qualquer. O algoritmo deve parar quando for
            //digitada a idade igual a zero.
            var sum = 0.0;
            for (var counter = 0; true; counter++)
            {
                System.Console.WriteLine("Digite uma idade: ");
                var input = Console.ReadLine();
                if(input == "0")
                {
                    var average = (sum/counter).ToString("0.00");
                    System.Console.WriteLine($"A média de idades é {average}");
                    break;
                }
                try
                {
                    sum += Int32.Parse(input);
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Idade inválida!");
                    counter--;
                }
            }
        }

        static void Exercicio5()
        {
            var womenBetween18And35 = 0;
            for (int counter = 0; counter < 5; counter++)
            {
                System.Console.WriteLine("Informe o nome: ");
                Console.ReadLine();
                System.Console.WriteLine("Informe a idade: ");
                var input = int.MinValue;
                while (true)
                {
                    try
                    {
                        input = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Idade inválida! Digite um novo valor: ");
                    }
                }
                if(input > 17 && input <36)
                {
                    womenBetween18And35++;
                }
            }
            System.Console.WriteLine($"O percentual de mulheres com idade entre 18 e 35 anos é {womenBetween18And35 * 100 / 5}");
        }

        static void Exercicio6()
        {
            const string registerMode = "1";
            const string votesMode = "2";
            const string resultMode = "3"; 

            var candidates = new (string name, int votes)[2];

            while (true)
            {
                System.Console.WriteLine("Escolha uma das opções abaixo:");
                System.Console.WriteLine($"{registerMode}. Cadastro");
                System.Console.WriteLine($"{votesMode}. Voto");
                System.Console.WriteLine($"{resultMode}. Apuração");
                var mode = Console.ReadLine();

                if(mode == resultMode)
                {
                    break;
                }

                if(mode == registerMode)
                {
                    var password = "";
                    while (password != "password")
                    {
                        System.Console.WriteLine("Informe a senha para cadastrar candidatos: ");
                        password = Console.ReadLine();
                    }
                    for (int i = 0; i < candidates.Length; i++)
                    {
                        System.Console.WriteLine("Informe o nome do candidato:");
                        candidates[i].name = Console.ReadLine();
                    }
                }

                if(mode == votesMode)
                {
                    System.Console.WriteLine("Informe o numero do candidato:");
                    System.Console.WriteLine($"1. {candidates[0].name}");
                    System.Console.WriteLine($"2. {candidates[1].name}");
                    var vote = int.MinValue;
                    while (true)
                    {
                        try
                        {
                            vote = Int32.Parse(Console.ReadLine());
                            if(vote == 1 || vote == 2)
                            {
                                break;
                            }else
                            {
                                System.Console.WriteLine("Candidato não encontrado. Digite novamente: ");
                            }
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Vote inválido. Digite o número novamente: ");
                        }
                    }
                    candidates[vote - 1].votes++;
                }

            }
            System.Console.WriteLine("Apuração dos votos:");
            if (candidates[0].votes == candidates[1].votes)
            {
                System.Console.WriteLine("Segundo turno!");
            }else
            {
                var winner = candidates[0];
                for (int i = 1; i < candidates.Length; i++)
                {
                    var currentCandidates = candidates[i];
                    if(currentCandidates.votes > winner.votes)
                    {
                        winner = candidates[i]; 
                    }
                }
                System.Console.WriteLine($"O vencedor é {winner.name}, com o total de {winner.votes} votos.");
            }
        }

        static void Exercicio7()
        {
            var anos = 0;
            var cigarro = 0;
            var valor = 0.0;
            System.Console.WriteLine("Informe quantos anos você fuma:");
            while (true)
            {
                try
                {
                    anos = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Informação inválida, digite novamente: ");
                }
            }
            System.Console.WriteLine("Informe quantos cigarros você fuma por dia:");
            while (true)
            {
                try
                {
                    cigarro = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Informação inválida, digite novamente: ");
                }
            }
            System.Console.WriteLine("Informe o valor de uma carteira de cigarro");
            while (true)
            {
                try
                {
                    valor = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Informação inválida, digite novamente: ");
                }
            }
            var total = ((valor / 20) * cigarro * (anos * 365));
            System.Console.WriteLine("O valor gasto em cigarros foi de:" + total);
        }

        static void Exercicio8()
        {
            var n1 = 0;
            var n2 = 0;
            System.Console.WriteLine("Digite o dividendo: ");
            n1 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o divisor: ");
            n2 = Int32.Parse(Console.ReadLine());
            if(n1 % n2 == 0)
            {
                System.Console.WriteLine("O número " + n1 + " é multiplo de " + n2 + "!");
            }else
            {
                System.Console.WriteLine("O número " + n1 + " não é multiplo de "+n2+"!");
            }
        }

        static void Exercicio9()
        {
            System.Console.WriteLine("Digite o primeiro número: ");
            var n1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            var n2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceito número: ");
            var n3 = double.Parse(Console.ReadLine());
            var soma = n2 + n3;
            if(n1 > soma)
            {
                System.Console.WriteLine("O número " + n1 + " é maior que " + soma);
            }else
            {
                System.Console.WriteLine("O número " + n1 + " não é maior que " + soma);
            }
        }

        static void Exercicio10()
        {
            System.Console.WriteLine("Digite o primeiro número: ");
            var n1 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            var n2 = Int32.Parse(Console.ReadLine());
            if( n1 > n2)
            {
                System.Console.WriteLine("O primeiro número "+n1+" é maior que o segundo."+n2);
            }else if( n1 < n2)
            {
                System.Console.WriteLine("O segundo número "+n2+" é maior que o primeiro."+n1);
            }else
            {
                System.Console.WriteLine("Os números "+n1+" e "+n2+" são iguais.");
            }
        }

        static void Exercicio11()
        {
            System.Console.WriteLine("Informe o dividendo: ");
            var n1 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe o divisor: ");
            var n2 = Int32.Parse(Console.ReadLine());
            if(n2 != 0)
            {
                System.Console.WriteLine(n1/n2);
            }else
            {
                System.Console.WriteLine("DIVISÃo POR ZERO");
            }
        }

        static void Exercicio12()
        {
            
        }

        static void Exercicio13()
        {
            var resultado = 0;
            for(var i = 0 ; i < 10 ; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número: ");
                var numero = Int32.Parse(Console.ReadLine());
                if(numero > resultado)
                {
                    resultado = numero;
                }
            }
            System.Console.WriteLine($"O maior número é {resultado}.");
        }

        static void Exercicio14()
        {
            var num = new double[3];

            for(var i = 0 ; i < 3 ; i++)
            {
                System.Console.WriteLine($"Digite o {i+1}º número:");
                num[i] = Double.Parse(Console.ReadLine());
            }
            if(num[0] > num[1] && num[0] > num[2])
            {
                var temp = num[2];
                num[2] = num[0];
                num[0] = temp;
            }
            if(num[1] > num[0] && num[1] > num[2])
            {
                var temp = num[2];
                num[2] = num[1];
                num[1] = temp;
            }
            if(num[0] > num[1])
            {
                var temp = num[1];
                num[1] = num[0];
                num[0] = temp;
            }
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine(num[i]);
            }
        }

        static void Exercicio15()
        {
            var multiple3 = 0;
            var multiple5 = 0;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número:");
                var input = Int32.Parse(Console.ReadLine());
                if((input % 3) == 0)
                {
                    multiple3++;
                }
                if((input % 5) == 0)
                {
                    multiple5++;
                }
            }
            System.Console.WriteLine($"Foram digitados {multiple3} números multiplos de 3.");
            System.Console.WriteLine($"Foram digitados {multiple5} números multiplos de 5.");
        }

        static void Exercicio16()
        {
            var salario = 0.0;
            var desconto = 0.0;
            System.Console.WriteLine("Digite o salario: ");
            var input = Double.Parse(Console.ReadLine());
            if(input <= 600)
            {
                salario = input;
            }else if(input > 600 && input <= 1200)
            {
                desconto = input / 100 * 20;
                salario = input - desconto;
            }else if(input > 1200 && input <= 2000)
            {
                desconto = input / 100 * 25;
                salario = input - desconto;
            }else
            {
                desconto = input / 100 * 30;
                salario = input - desconto;
            }
            System.Console.WriteLine($"Salario líquido: {salario.ToString("0.00")}");
        }

        static void Exercicio17()
        {
            System.Console.WriteLine("Informe um número: ");
            var num = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                System.Console.WriteLine($"{i} X {num} = {i * num}");
            }
        }

        static void Exercicio18()
        {
            System.Console.WriteLine("Informe a quantidade: ");
            var input = Int32.Parse(Console.ReadLine());
            if(input >= 12)
            {
                System.Console.WriteLine($"O valor total é de R$ {input * 1}");
            }else
            {
                System.Console.WriteLine($"O valor total é de R$ {input * 1.3}");
            }
        }

        static void Main(string[] args)
        {
            Exercicio6();
        }
    }
}
