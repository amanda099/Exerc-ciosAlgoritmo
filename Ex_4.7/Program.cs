//7.Melhore o algoritmo do exercício anterior
//verificando se o número inserido pelo
//usuário é zero, par ou ímpar.


float numero;

Console.WriteLine("Digite um número");
numero = float.Parse(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("NÚMERO ZERO É NEUTRO");
}

else
{
    if (numero > 0)
    {
        Console.Write("O número " + numero + " é positivo");

        if (numero % 2 == 0)
        {
            Console.WriteLine(" e par");
        }

        else
        {
            Console.WriteLine(" e ímpar");
        }

    }

    else
    {
        Console.Write("O número " + numero + " é negativo");

        if (numero % 2 == 0)
        {
            Console.WriteLine(" e par");
        }

        else
        {
            Console.WriteLine(" e ímpar");
        }

    }


}


Console.ReadKey();







