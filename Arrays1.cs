using System;

namespace listaarray
{
    class Arrays
    {
        static void Exercicio1()
        {
            // 1-Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada elemento de C
            // é a subtração do elemento correspondente de A com B.

            //input: 

            var a = new double[3];
            var b = new double[3];
            var c = new double[3];
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Informe um número");
                while (true)
                {
                    try
                    {
                        a[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor!");
                    }
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                System.Console.WriteLine("Informe um número");
                while (true)
                {
                    try
                    {
                        b[i] = Double.Parse(Console.ReadLine());
                        c[i] = a[i] - b[i];
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor!");
                        throw;
                    }
                }
            }
            //não foi solicitado imprimir o array C, porém para fins de teste fiz o for abaixo
            foreach (var item in c)
            {
                System.Console.WriteLine(item);
            }
        }

        static void Exercicio2()
        {
            // 2-Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram
            // lidos.
            var numbers = new int [10];
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número: ");
                while (true)
                {
                    try
                    {
                        numbers[i] = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor!");
                    }
                }
                
            }
            System.Console.WriteLine("Direta: ");
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Inversa: ");
            for (int i = 9; i > -1; i--)
            {
                System.Console.WriteLine(numbers[i]);
            }
        }

        static void Exercicio3()
        {
            // 3-Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um
            // número qualquer e pesquise no array se o número existe. Caso, seja verdade imprima a
            // mensagem: “O número existe no array” , caso contrário “Número inexistente”.
            var numbers = new double[10];
            var result = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número: ");
                while (true)
                {
                    try
                    {
                        numbers[i] = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine($"Número inválido! Informe o {i+1}º número: ");
                    }
                }
                
            }
            System.Console.WriteLine("Informe o número a ser pesquisado: ");
            double input = 0;
            while (true)
                {
                    try
                    {
                        input = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine($"Número inválido! Informe o número novamente: ");
                    }
                }
            
            foreach (var item in numbers)
            {
                if(input == item)
                {
                    result = true;
                    break;
                }
            }
            if(result)
            {
                System.Console.WriteLine("O número existe no array");
            }else
            {
                System.Console.WriteLine("Número inexistente");
            }
        }

        static void Exercicio4()
        {
            // 4-Leia dois arrays A e B com 10 elementos. Em seguida, compare os arrays e verifique se
            // os mesmos são iguais ou diferentes.
            var a = new double?[3];
            var b = new double[3];
            var equal = false; //apenas para testar o resultado
            System.Console.WriteLine("+++ Primeira lista +++");
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número");
                while (true)
                {
                    try
                    {
                        a[i] = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine($"Número inválido! Informe o {i+1}º número");
                    }
                }
                
            }
            System.Console.WriteLine("+++ Segunda lista +++");
            for (int i = 0; i < b.Length; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número");
                while (true)
                {
                    try
                    {
                        b[i] = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine($"Número inválido! Informe o {i+1}º número");
                    }
                }
                for (int j = 0; j < a.Length; j++)
                {
                    equal = false;
                    if(a[j] == b[i])
                    {
                        equal = true;
                        a[j] = null;
                        break;
                    }
                }
            }
            var message = (equal) ? "Os arrays são iguais!" : "Os arrays são diferentes!";
            System.Console.WriteLine(message);
        }

        static void Exercicio5()
        {
            // 5-Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, em
            // seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            var a = new double[15];
            var total = 0.0;
            var smaller = 0;
            var equal = 0;
            var greater = 0;
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine($"Informe o {i+1}º número");
                while (true)
                {
                    try
                    {
                        a[i] = double.Parse(Console.ReadLine());
                        total += a[i];
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor!");
                    }
                }
            }
            var middle = total / a.Length;
            System.Console.WriteLine($"Média aritmética é {middle.ToString("0.00")}");
            foreach (var item in a)
            {
                if(item < middle)
                {
                    smaller++;
                }else if(item > middle)
                {
                    greater++;
                }else
                {
                    equal++;
                }
            }
            System.Console.WriteLine($"{smaller} número(s) menores que {middle.ToString("0.00")}");
            System.Console.WriteLine($"{equal} número(s) iguais a {middle.ToString("0.00")}");
            System.Console.WriteLine($"{greater} número(s) maiores que {middle.ToString("0.00")}");
        }

        static void Exercicio6()
        {
            const int arraylength = 12;
            var a = new double[arraylength];
            var b = new double[arraylength];
            var c = new double[arraylength];
            for (int i = 0; i < arraylength; i++)
            {
                a[i] = double.MinValue;
                b[i] = double.MaxValue;
                c[i] = double.MinValue;
            }
            System.Console.WriteLine("+++ Primeira lista +++");
            for (int i = 0; i < arraylength; i++)
            {
                double input = double.MinValue;
                System.Console.WriteLine($"Informe {i+1}º número");
                while (true)
                {
                    try
                    {
                        input = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor: ");
                    }
                }
                if(input > a[11])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = a[5];
                    a[5] = a[6];
                    a[6] = a[7];
                    a[7] = a[8];
                    a[8] = a[9];
                    a[9] = a[10];
                    a[10] = a[11];
                    a[11] = input;
                }else if(input > a[10])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = a[5];
                    a[5] = a[6];
                    a[6] = a[7];
                    a[7] = a[8];
                    a[8] = a[9];
                    a[9] = a[10];
                    a[10] = input;
                }else if(input > a[9])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = a[5];
                    a[5] = a[6];
                    a[6] = a[7];
                    a[7] = a[8];
                    a[8] = a[9];
                    a[9] = input;
                }else if(input > a[8])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = a[5];
                    a[5] = a[6];
                    a[6] = a[7];
                    a[7] = a[8];
                    a[8] = input;
                }else if(input > a[7])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = a[5];
                    a[5] = a[6];
                    a[6] = a[7];
                    a[7] = input;
                }else if(input > a[6])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = a[5];
                    a[5] = a[6];
                    a[6] = input;
                }else if(input > a[5])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = a[5];
                    a[5] = input;
                }else if(input > a[4])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = a[4];
                    a[4] = input;
                }else if(input > a[3])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = a[3];
                    a[3] = input;
                }else if(input > a[2])
                {
                    a[0] = a[1];
                    a[1] = a[2];
                    a[2] = input;
                }else if(input > a[1])
                {
                    a[0] = a[1];
                    a[1] = input;
                }else if(input > a[0])
                {
                    a[0] = input;
                }
            }
            System.Console.WriteLine("+++ ARRAY A +++");
            for (int i = 0; i < arraylength; i++)
            {
                System.Console.WriteLine(a[i]);
            }
            System.Console.WriteLine("+++ Segunda lista +++");
            for (int i = 0; i < 12; i++)
            {
                double input = double.MinValue;
                System.Console.WriteLine($"Informe {i+1}º número");
                while (true)
                {
                    try
                    {
                        input = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor: ");
                    }
                }
                if(input < b[11])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = b[5];
                    b[5] = b[6];
                    b[6] = b[7];
                    b[7] = b[8];
                    b[8] = b[9];
                    b[9] = b[10];
                    b[10] = b[11];
                    b[11] = input;
                }else if(input < b[10])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = b[5];
                    b[5] = b[6];
                    b[6] = b[7];
                    b[7] = b[8];
                    b[8] = b[9];
                    b[9] = b[10];
                    b[10] = input;
                }else if(input < b[9])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = b[5];
                    b[5] = b[6];
                    b[6] = b[7];
                    b[7] = b[8];
                    b[8] = b[9];
                    b[9] = input;
                }else if(input < b[8])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = b[5];
                    b[5] = b[6];
                    b[6] = b[7];
                    b[7] = b[8];
                    b[8] = input;
                }else if(input < b[7])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = b[5];
                    b[5] = b[6];
                    b[6] = b[7];
                    b[7] = input;
                }else if(input < b[6])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = b[5];
                    b[5] = b[6];
                    b[6] = input;
                }else if(input < b[5])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = b[5];
                    b[5] = input;
                }else if(input < b[4])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[4];
                    b[4] = input;
                }else if(input < b[3])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = input;
                }else if(input < b[2])
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = input;
                }else if(input < b[1])
                {
                    b[0] = b[1];
                    b[1] = input;
                }else if(input < b[0])
                {
                    b[0] = input;
                }
            }
            System.Console.WriteLine("+++ ARRAY B +++");
            for (int i = 0; i < arraylength; i++)
            {
                System.Console.WriteLine(b[i]);
            }
            for (int i = 0; i < arraylength; i++)
            {
                var input = a[i] + b[i];
                if(input > c[11])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = c[5];
                    c[5] = c[6];
                    c[6] = c[7];
                    c[7] = c[8];
                    c[8] = c[9];
                    c[9] = c[10];
                    c[10] = c[11];
                    c[11] = input;
                }else if(input > c[10])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = c[5];
                    c[5] = c[6];
                    c[6] = c[7];
                    c[7] = c[8];
                    c[8] = c[9];
                    c[9] = c[10];
                    c[10] = input;
                }else if(input > c[9])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = c[5];
                    c[5] = c[6];
                    c[6] = c[7];
                    c[7] = c[8];
                    c[8] = c[9];
                    c[9] = input;
                }else if(input > c[8])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = c[5];
                    c[5] = c[6];
                    c[6] = c[7];
                    c[7] = c[8];
                    c[8] = input;
                }else if(input > c[7])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = c[5];
                    c[5] = c[6];
                    c[6] = c[7];
                    c[7] = input;
                }else if(input > c[6])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = c[5];
                    c[5] = c[6];
                    c[6] = input;
                }else if(input > c[5])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = c[5];
                    c[5] = input;
                }else if(input > c[4])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = c[4];
                    c[4] = input;
                }else if(input > c[3])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = c[3];
                    c[3] = input;
                }else if(input > c[2])
                {
                    c[0] = c[1];
                    c[1] = c[2];
                    c[2] = input;
                }else if(input > c[1])
                {
                    c[0] = c[1];
                    c[1] = input;
                }else if(input > c[0])
                {
                    c[0] = input;
                }
            }
            System.Console.WriteLine("+++ ARRAY C +++");
            for (int i = 0; i < arraylength; i++)
            {
                System.Console.WriteLine(c[i]);
            }
        }

        static void Main(string[] args)
        {
            Exercicio6();
        }
    }
}
