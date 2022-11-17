
// 10.	Para auxiliar na elaboração da folha de pagamento, uma empresa precisa de um programa que calcule,
// para cada valor de salário fornecido, os descontos relativos ao imposto de renda, à contribuição ao INSS e a mensalidade do plano de saúde 
// (utilize as tabelas 5.2 e 5.3). Como resultado, o algoritmo deve mostrar:

// O valor total da folha de pagamento da empresa.
// O salário líquido de cada funcionário.
// O valor total do imposto de renda que a empresa deve recolher


string nome, op;
double sal_bruto, sal_ajuste, imposto_renda = 0, inss = 0, imposto_total = 0, pagamento_total = 0;

do
{
    Console.WriteLine("==============CADASTRO DE CANDIDATO==============");
    Console.Write("Informe o nome do funcionário: ");
    nome = Console.ReadLine();
    Console.Write("Informe o salário bruto do funcionário: R$");
    sal_bruto = double.Parse(Console.ReadLine());

    Console.Clear();

    sal_ajuste = sal_bruto;
    pagamento_total += sal_bruto;

    //imposto de renda

    if (sal_bruto >= 1903.99 && sal_bruto < 2826.66)
    {
        imposto_renda += sal_bruto * 0.075;
        sal_ajuste = sal_bruto - (sal_bruto * 0.075);
    }

    else if (sal_bruto >= 2826.66 && sal_bruto < 3751.06)
    {
        imposto_renda += sal_bruto * 0.15;
        sal_ajuste = sal_bruto - (sal_bruto * 0.15);
    }

    else if (sal_bruto >= 3751.06 && sal_bruto < 4664.68)
    {
        imposto_renda += sal_bruto * 0.225;
        sal_ajuste = sal_bruto - (sal_bruto * 0.225);
    }

    else if (sal_bruto > 4664.68)
    {
        imposto_renda += sal_bruto * 0.275;
        sal_ajuste = sal_bruto - (sal_bruto * 0.275);
    }

    //inss

    if (sal_ajuste < 1556.95)
    {
        inss += sal_ajuste * 0.08;
        sal_ajuste = sal_ajuste - (sal_ajuste * 0.08);
    }

    if (sal_ajuste >= 1556.95 && sal_ajuste < 2594.93)
    {
        inss += sal_ajuste * 0.09;
        sal_ajuste = sal_ajuste - (sal_ajuste * 0.09);
    }

    if (sal_ajuste >= 2594.93 && sal_ajuste < 5189.92)
    {
        inss += sal_ajuste * 0.11;
        sal_ajuste = sal_ajuste - (sal_ajuste * 0.11);
    }

    Console.WriteLine("Funcionário: " + nome);
    Console.WriteLine("Salário bruto: R$" + sal_bruto);
    Console.WriteLine("Salário líquido: R$" + sal_ajuste);

    imposto_total = imposto_renda + inss;

    Console.Write("Deseja cadastrar outro funcionário? (S/N) - ");
    op = Console.ReadLine().ToUpper();

    Console.Clear();

} while (op == "S");


Console.WriteLine("=============================================================");
Console.WriteLine("Valor total da folha de pagamento: R$" + pagamento_total);
Console.WriteLine("Valor total de imposto de renda que deve ser recolhido pela empresa: R$" + imposto_renda);
Console.WriteLine("Valor total de inss que deve ser recolhido pela empresa: R$" + inss);
Console.WriteLine("Valor total de impostos que a empresa deve recolher: R$" + imposto_total);
Console.WriteLine("=============================================================");

Console.ReadKey();