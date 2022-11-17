//5.Considerando a sequência de Fibonacci (1, 1, 2, 3, 5, 8, 13 ... n), escreva um algoritmo
//para gerar esta sequência, até o enésimo termo, fornecido pelo usuário. Por exemplo, se o
//usuario digitou o número 40, deverão ser gerados os primeiros 40 números.



int numerotermos, num1 = 0, fib = 0;
int num2 = 1;

Console.Write("Insira até que termo deseja visualizar a sequência de Fibonacci: ");
numerotermos = int.Parse(Console.ReadLine());

for (int i = 1; i <= numerotermos; i++)
{
    fib = num1 + num2;
    Console.WriteLine(fib + "\n");
    num1 = num2;
    num2 = fib;
}

Console.ReadKey();