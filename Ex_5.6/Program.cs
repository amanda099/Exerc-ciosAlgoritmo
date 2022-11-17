// 6.Escreva um algoritmo que, a partir de um número “n” fornecido pelo usuario,
// execute os cálculos a seguir, enquanto este “n” for diferente de 1.
//a)	Se “n” for par, n = n + 2.
//b) Se “n” for ímpar, n = n x 3 + 1.
//Explique o que acontece quando o programa é executado.


float n;

do
{

    Console.WriteLine("Digite um número, diferente de '1'");
    n = int.Parse(Console.ReadLine());

    if (n != 1)
    {
        if (n % 2 == 0)
        {
            float resultado;
            resultado = n + 2;
            Console.WriteLine("O número digitado foi: " + n + ", por ser um número par o resultado da operação indicada é => " + resultado + "\n");
        }
        else
        {
            float resultado;
            resultado = n * 3 + 1;
            Console.WriteLine("O número digitado foi: " + n + ", por ser um número ímpar o resultado da operação indicada é => " + resultado + "\n");
        }
    }    

} while (n != 1);


Console.WriteLine("NÚMERO '1' É INVÁLIDO");


Console.ReadKey();
