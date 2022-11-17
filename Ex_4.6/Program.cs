//6.Verifique se um número fornecido pelo usuário é par ou ímpar.
//Para isto, apresente uma mensagem mostrando o número digitado e
//o resultado do teste.

float numero, resto;

Console.WriteLine("Digite um número");
numero = float.Parse(Console.ReadLine());

Console.Clear();

if (numero % 2 == 0)
{
    Console.WriteLine("O número " + numero + " é PAR");
}
else
{
    Console.WriteLine("O número " + numero + " é ÍMPAR");
}

Console.ReadKey();
