// 7.Construa um algoritmo que encontre a mediana de uma sequência de números inteiros,
// fornecida pelo usuario (número inicial e final), utilizando uma estrutura de repetição.
//Por exemplo, a mediana da sequência “ 1, 2,
//3, 4, 5” é 3 e a da sequência “2, 3, 4, 5, 6,
//7s 8, 9” 6 (5 + 6) +2 - 5,5.Como sugestão, utilize a variavel i para
//o número inicial e j para o final, realizando operaçóes de incremento e decremento.


List<int> numeros = new List<int>();
double mediana;

Console.Write("Insira o número inicial: ");
int numero_inicial = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o número final: ");
int numero_final = Convert.ToInt32(Console.ReadLine());

for (int i = numero_inicial; i <= numero_final; i++)
{
    numeros.Add(i);
}

if (numeros.Count % 2 == 0)
{
    mediana = (numeros[(numeros.Count / 2) - 2] + numeros[(numeros.Count / 2) - 1] / 2);
}

else
{
    mediana = numeros[(numeros.Count / 2)];
}

Console.WriteLine("A mediana é: " + mediana);

Console.ReadKey();