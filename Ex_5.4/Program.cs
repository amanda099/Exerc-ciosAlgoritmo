//4.A partir de um conjunto de números inteiros sequenciais, obtidos com base em dados
//fornecidos pelo usuário (número inicial e final), identifique e apresente:
//a)	A quantidade de números inteiros e positivos.
//b)	A quantidade de números pares.
//c)	A quantidade de números ímpares.
//d)	A quantidade de números ímpares e divisíveis por 3 e 7.
//e)	A respectiva média para cada um dos itens.


int numinicial, numfinal, numpositivos = 0, numpares = 0, numimpares = 0, num37 = 0, somapos = 0, somapares = 0, somaimpares = 0, soma37 = 0;
double mediapos = 0, mediapares = 0, mediaimp = 0, media37 = 0;

Console.WriteLine("Insira o número inicial: ");
numinicial = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o número final: ");
numfinal = int.Parse(Console.ReadLine());

do
{
    numinicial++;

    if (numinicial > 0)
    {

        numpositivos++;
        somapos += numinicial;

        if (numinicial % 2 == 0)
        {
            numpares++;
            somapares += numinicial;
        }

        else
        {
            if (numinicial % 3 == 0 && numinicial % 7 == 0)
            {
                num37++;
                soma37 += numinicial;
            }

            numimpares++;
            somaimpares += numinicial;
        }

    }

} while (numinicial <= numfinal);


mediapos = somapos / numpositivos;
mediapares = somapares / numpares;
mediaimp = somaimpares / numimpares;

if (num37 == 0)
{
    media37 = soma37 / 1;
}

else
{
    media37 = soma37 / num37;
}

Console.Clear();

Console.WriteLine("a)" + "\n Neste intervalo, há " + numpositivos + " número(s) inteiro(s) e positivo(s)." + "\n");

Console.WriteLine("b)" + "\n Há " + numpares + " número(s) par(es)." + "\n");

Console.WriteLine("c)" + "\n Há " + numimpares + " número(s) ímpar(es)." + "\n");

Console.WriteLine("d)" + "\n Há " + num37 + " número(s) ímpar(es) e divisível(is) por 3 e 7." + "\n");


Console.WriteLine("e) " + "\n ----- MÉDIA -----");
Console.WriteLine("Números inteiros e positivos: " + mediapos);
Console.WriteLine("Números pares: " + mediapares);
Console.WriteLine("Números ímpares: " + mediaimp);
Console.WriteLine("Números ímpares e divisíveis por 3 e 7: " + media37);

Console.ReadKey();