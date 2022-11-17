//1.Leia 4 valores, calcule a soma entre eles e apresente o resultado.

float a, b, c, d, soma;

Console.WriteLine("Digite 4 números");
a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());
c = float.Parse(Console.ReadLine());
d = float.Parse(Console.ReadLine());

soma = a + b + c + d;

Console.WriteLine("A soma entre os números digitados é:");
Console.WriteLine(soma);

Console.ReadKey();