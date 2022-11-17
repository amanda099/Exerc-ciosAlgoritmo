//Escreva um algoritmo que calcule e exiba a tabuada, até um determinado número “n”,
//fornecido pelo usuário, lembrando que, se o número fornecido é 4, deve ser gerada a
//tabuada do 1, 2, 3 e 4, com as operaçóes de multiplicação e o resultado no formato:
//i x i = 1
//1 x 2 = 2
//1 x 5 = 5

int n;
int i, x;
int formula;

Console.Write("Informe até qual tabuada deseja consultar: ");
n = int.Parse(Console.ReadLine());

for (x = 1; x <= n; x++)
{
    for (i = 1; i <= 10; i++)
    {
        formula = x * i;
        Console.WriteLine(x + " X " + i + " = " + formula);
    }

    Console.WriteLine("\n");
}


Console.ReadKey();

