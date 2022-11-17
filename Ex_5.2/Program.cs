//2.Pedro tem 1,50 m e cresce 2 cm por ano, enquanto Lucas tem 1,10 m e cresce 3 cm por ano.
//Construa um algoritmo que calcule e imprima quantos anos seráo necessários para que:
//a)	Lucas e Pedro tenham o mesmo tamanho.
//b)	Lucas seja maior que Pedro.



double alturapedro = 1.50;
double alturalucas = 1.10;
int ano = 0;

//a
do
{
    alturapedro = alturapedro + 0.02;
    alturalucas = alturalucas + 0.03;
    ano++;

} while (alturapedro >= alturalucas);

Console.WriteLine("a) Irá levar " + ano + " anos para que Lucas e Pedro tenham o mesmo tamanho." + "\n");


//b
do
{
    alturapedro = alturapedro + 0.02;
    alturalucas = alturalucas + 0.03;
    ano++;

} while (alturapedro > alturalucas);

Console.WriteLine("b) Irá levar " + ano + " anos para que Lucas seja maior que Pedro.");

Console.ReadKey();











