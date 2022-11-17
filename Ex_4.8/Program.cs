//8.De acordo com um valor fornecido pelo usuário,
//verifique se ele é multíplo de 3, ou múltiplo de 7.
//Apresente uma mensagem mostrando o número digitado e o
//resultado do teste.

using System;

float numero;

Console.WriteLine("Digite um número");
numero = float.Parse(Console.ReadLine());

Console.Clear();

if (numero % 3 == 0)
{
    if (numero == 0)
    {
        Console.WriteLine("NÚMERO ZERO É NEUTRO");
    }

    else
    {
        Console.WriteLine("O número " + numero + " é múltiplo de 3");
    }
    
}
else if(numero % 7 == 0)
{
    if (numero == 0)
    {
        Console.WriteLine("NÚMERO ZERO É NEUTRO");
    }

    else
    {
        Console.WriteLine("O número " + numero + " é múltiplo de 7");
    };
}
else
{
    Console.WriteLine("O número " + numero + " não é nem múltiplo de 3 e nem de 7");
}

Console.ReadKey();