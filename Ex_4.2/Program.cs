//2.Leia 3 valores, calcule a média aritmética entre eles e apresente o resultado.

float a, b, c, media;

Console.WriteLine("Digite 3 números");
a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());
c = float.Parse(Console.ReadLine());

media = (a + b + c) / 3;

Console.WriteLine("A média aritmética dos números digitados é:");
Console.Write(media);

Console.ReadKey();