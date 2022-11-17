//10.Uma loja de departamentos está oferecendo diferentes formas de pagamento,
//conforme as opçóes listadas a seguir. Faça um algoritmo que leia o valor total
//de uma compra e calcule o valor do pagamento final de acordo com a opçáo escolhida.
//Se a escolha for por pagamento parcelado, calcule tambêm o valor da parcela. Ao final,
//apresente o valor total e o valor das parcelas.
//a)	Pagamento à vista — conceder desconto de 5%.
//b)	Pagamento em 3 parcelas — o valor não sofre alteração.
//c)	Pagamento em 5 parcelas — acréscimo de 2%.
//d)	Pagamento em 10 parcelas — acréscimo de 8%.


string nome;
double total_compra;
int pagamento;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.Clear();

Console.WriteLine("Olá " + nome + "! Por favor informe o valor total de sua compra.");
total_compra = double.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("=========================FORMA DE PAGAMENTO=========================");
Console.WriteLine("Escolha a forma que deseja realizar o pagamento: ");
Console.WriteLine("Parcelamento a vista, desconto de 5% -> digite 1");
Console.WriteLine("Parecelamento em 3 parcelas, sem juros -> digite 2");
Console.WriteLine("Parecelamento em 5 parcelas, acréscimo de 2% -> digite 3");
Console.WriteLine("Parecelamento em 10 parcelas, acréscimo de 8% -> digite 4");
Console.WriteLine("====================================================================");
pagamento = int.Parse(Console.ReadLine());

Console.Clear();

double valor_final;
double parcela;

switch (pagamento)
{
	case 1:        
        valor_final = total_compra - (total_compra * 0.05); 
        Console.WriteLine("Forma de Pagamento escolhido => A vista, desconto de 5%");
        Console.WriteLine("Valor total: R$" + valor_final);
        break;

	case 2:        
        parcela = total_compra / 3;
        Console.WriteLine("Forma de Pagamento escolhido => Parecelamento em 3 parcelas, sem juros");
        Console.WriteLine("Valor total: R$" + total_compra);
        Console.WriteLine("3 parcela no valor de R$ " + parcela);
        break;

    case 3:
        valor_final = total_compra + (total_compra * 0.02);
        parcela = total_compra / 5;
        Console.WriteLine("Forma de Pagamento escolhido => Parecelamento em 5 parcelas, acréscimo de 2%");
        Console.WriteLine("Valor total: R$" + valor_final);
        Console.WriteLine("5 parcela no valor de R$ " + parcela);
        break;

    case 4:
        valor_final = total_compra + (total_compra * 0.08);
        parcela = total_compra / 10;
        Console.WriteLine("Forma de Pagamento escolhido => Parecelamento em 10 parcelas, acréscimo de 8%");
        Console.WriteLine("Valor total: R$" + valor_final);
        Console.WriteLine("10 parcela no valor de R$ " + parcela);
        break;

    default:

		break;
}

Console.ReadKey();