//9.Um aluno realizou trés provas de uma determinada disciplina.
//Levando em consideração o critério apresentado a seguir, faça
//um programa que mostre se ele ficou para exame e, em caso positivo,
//que nota este aluno precisa obter, no exame, para passar de ano.
//Média = (Proval + Prova2 + Prova3) / 3
//A média deve ser maior ou igual a 7,0. Se não conseguir, a nova média deve ser:
//Final = (Média + Exame) / 2
//A média final, para aprovação, deve ser
//maior ou igual a 5,0.

string nome;
float nota1, nota2, nota3, media, final, exame = 0, nota;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.Clear();

Console.WriteLine("Olá " + nome + ", por favor informe suas notas das 4 provas!");
nota1 = float.Parse(Console.ReadLine());
nota2 = float.Parse(Console.ReadLine());
nota3 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.Clear();

if (media >= 7.0)
{
    nome = nome.ToUpper();
    Console.WriteLine("============================================");
    Console.WriteLine("PARABÉNS " + nome + ", VOCÊ PASSOU DE ANO!!");
    Console.WriteLine("============================================");
}
else
{
    nota = 10 - media;
    Console.WriteLine("=====================");
    Console.WriteLine("VOCÊ ESTÁ DE EXAME!, sua média é: " + media + " pontos, irá precisar de " + nota + " pontos para passar!");
    Console.WriteLine("=====================");
    final = (media + exame) / 2;

    Console.Clear();

    if (final >= 5.0)
    {
        Console.WriteLine("Parabéns você etá aprovado!!");
    }

    else
    {
        Console.WriteLine("Infelizmente você está reprovado!");
    }

}

Console.ReadKey();
