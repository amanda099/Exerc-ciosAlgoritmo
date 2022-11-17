//4.Uma empresa concedera um reajuste salarial de 8,75% no próximo més. Sua missão
//é elaborar um algoritmo que, a partir de dados inseridos pelo usuário, calcule o salá-
//rio reajustado de um funcionário, exibindo, como resultado, seu nome, o valor de seu
//salário atual e o valor do salário reajustado.

string nome;
double salario_atual, salario_reajuste;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.Clear();

Console.WriteLine("Olá, " + nome + "!");
Console.WriteLine("Infome o valor do su salário atual!");
salario_atual = double.Parse(Console.ReadLine());

Console.Clear();

salario_reajuste = salario_atual + (salario_atual * 0.0875);

Console.WriteLine("========================REAJUSTE SALARIAL========================");
Console.WriteLine("Funcionário: " + nome);
Console.WriteLine("Sálario atual informado: R$" + salario_atual);
Console.WriteLine("Após o reajuste seu salário sera: R$" + salario_reajuste);
Console.WriteLine("=================================================================");


Console.ReadKey();




