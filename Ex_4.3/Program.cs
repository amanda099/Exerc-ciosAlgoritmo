//3.Uma loja de produtos eletronicos com vendas regulares opta por contratar uma equipe
//para a organização de um sistema de gerenciamento de vendas. Seu desafio será elaborar
//um algoritmo que, a partir de dados fornecidos pelo usuário, calcule o valor da venda
//de um produto, exibindo uma saída em vídeo contendo o código do produto, o nome, a
//quantidade comprada, o valor unitário e o valor total.

double valor_vend, quant_prod, valorunit_prod, valor_total;
string cod_prod, nome_prod;

Console.WriteLine("======================SEJA BEM VINDO(A)======================");
Console.WriteLine("Informe o código e em seguida o nome do produto");
cod_prod = Console.ReadLine();
nome_prod = Console.ReadLine();

Console.Clear();

Console.WriteLine(cod_prod + " ===> " + nome_prod);
Console.WriteLine("Infome agora a quantidade comprada e em seguida o valor unitário do produto");
quant_prod = double.Parse(Console.ReadLine());
valorunit_prod = double.Parse(Console.ReadLine());

Console.Clear();

valor_total = quant_prod * valorunit_prod;

Console.WriteLine("=======================================");
Console.WriteLine("O valor total da sua compra é: ");
Console.WriteLine("R$ " + valor_total);
Console.WriteLine("=======================================");

Console.ReadKey();

