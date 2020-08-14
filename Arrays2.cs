using System;

namespace listaarray2
{
    class Arrays2
    {
        static void Exercicio1()
        {
            // 1)Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos
            // vetores.
            const int arraylength = 10;
            var a = new int[arraylength]{12,98,23,87,45,65,32,78,21,89};
            var b = new int[arraylength]{14,96,47,63,25,85,36,74,69,41};
            for (int i = 0; i < arraylength; i++)
            {
                var temp = a[i];
                a[i] = b[i];
                b[i] = temp;
            }
            System.Console.WriteLine("Primeira lista");
            for (int i = 0; i < arraylength; i++)
            {
                System.Console.WriteLine(a[i]);
            }
            System.Console.WriteLine("Segunda lista");
            for (int i = 0; i < arraylength; i++)
            {
                System.Console.WriteLine(b[i]);
            }
        }

        static void Exercicio2()
        {
            // 2)Dado um vetor qualquer com 10 números, faça um programa que informa se há ou não
            // números repetidos nesse vetor.
            var numbers = new int?[10];
            var stop = false;
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = null;
                System.Console.WriteLine($"Informe o {i+1}º número: ");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if(!stop)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if(numbers[i] == numbers[j])
                        {
                        System.Console.WriteLine("Existem números repetidos neste vetor!");
                        stop = true;
                        break;
                        }
                    }
                }else
                {
                    break;
                }
            }
        }

        static void Exercicio3()
        {
            var yes = 0;
            var no = 0;
            var womenYes = 0;
            var menNo = 0;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe 'm' para mulher ou 'h' para homem: ");
                string input = Console.ReadLine();
                System.Console.WriteLine("Referente ao nosso novo produto lançado no mercado.");
                System.Console.WriteLine("Informe 's' se gostou ou 'n' se não gostou: ");
                string input2 = Console.ReadLine();
                if(input2 == "s")
                {
                    yes++;
                    if(input == "m")
                    {
                        womenYes++;
                    }
                }else if(input2 == "n")
                {
                    no++;
                    if(input == "h")
                    {
                        menNo++;
                    }
                }
            }
            System.Console.WriteLine($"{yes} pessoas responderam Sim.");
            System.Console.WriteLine($"{no} pessoas responderam Não.");
            System.Console.WriteLine($"{womenYes} mulheres responderam Sim.");
            System.Console.WriteLine($"{menNo} homens responderam Não.");
        }

        static void Exercicio4()
        {
            // 4)Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz // A do tipo vetor.
            // No final, apresente o total da soma de todos os elementos // que sejam impares.
            var a = new int[5];
            var odd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número");
                a[i] = Int32.Parse(Console.ReadLine());
                if(a[i] % 2 != 0)
                {
                    odd++;
                }
            }
            System.Console.WriteLine($"Você digitou {odd} números impares.");
        }

        static void Exercicio5()
        {
            // 5)Contar quantos valores de um vetor de 10 posições são positivos.
            var a = new double[10];
            var positive = 0;
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número");
                a[i] = double.Parse(Console.ReadLine());
                if(a[i] > -1)
                {
                    positive++;
                }
            }
            System.Console.WriteLine($"Foram informados {positive} números positivos.");
        }

        static void Exercicio6()
        {
            // 6)Ler um vetor de 10 posições (aceitar somente números positivos). Escrever a seguir o
            // valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.
            var a = new double[10];
            int? position = null;
            double bigger = double.MinValue;
            for (int i = 0; i < 10; i++)
            {
                var teste = true;
                while(teste)
                {
                    System.Console.WriteLine($"Informe {i+1}º número");
                    var input = double.Parse(Console.ReadLine());
                    if(input > -1)
                    {
                        a[i] = input;
                        teste = false;
                    }else
                    {
                        System.Console.WriteLine("Digite um número positivo.");
                    }
                }
                if(a[i] > bigger)
                {
                    bigger = a[i];
                    position = i;
                }
            }
            System.Console.WriteLine($"O maior número digitado foi {bigger}, que se encontra na posição {position} do array.");
        }

        static void Exercicio7()
        {
            // 7)Crie e popule um vetor A e imprima na tela o número de vezes que existe um número
            // residindo na mesma posição do vetor que seu valor numérico.
            var a = new int[10];
            int repet = 0;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número: ");
                a[i] = Int32.Parse(Console.ReadLine());
                if(a[i] == i)
                {
                    repet++;
                }
            }
            System.Console.WriteLine($"O numero digitado foi igual a posição do array {repet} vezes.");
        }

        static void Exercicio8()
        {
            // 8)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima quantas destas são vogais.
            var a = new string[10];
            var vowel = 0;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe uma letra");
                a[i] = Console.ReadLine();
                if(a[i] == "a" || a[i] == "e" || a[i] == "i" || a[i] == "o" || a[i] == "u")
                {
                    vowel++;
                }
            }
            System.Console.WriteLine($"Foram digitadas {vowel} vogais.");
        }

        static void Exercicio9()
        {
            // 9)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima a string resultante da soma das strings que residem em índices pares.
            var a = new string[10];
            var word = "";
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe uma letra");
                a[i] = Console.ReadLine();
                if(i % 2 == 0)
                {
                    word+=a[i];
                }
            }
            System.Console.WriteLine($"As letras '{word}' foram digitadas na posições pares do array.");
        }

        static void Main(string[] args)
        {
            Exercicio9();
        }
    }
}
