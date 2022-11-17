// 9.Uma empresa de recrutamento e seleção de funcionários possui, entre seus clientes, organizaçóes em diversos
// ramos de atividade. Atende, em média, 30 candidatos por dia, número que aumenta quando a demanda cresce em
// decorrência de períodos de recessão.

//Para facilitar o trabalho de identificação do perfil dos candidatos que se inscrevem para as vagas,
//a empresa optou por fazer um programa de registro de alguns dados, classificando as seguintes informaçóes:

//O número de candidatos do sexo feminino. 

//O número de candidatos do sexo masculino.

//A idade média dos homens com experiência.

//A idade média das mulheres com experiência.

//A percentagem dos homens entre 35 e 45 anos, entre o total dos homens.

//A menor idade entre as mulheres que ja têm experiencia no serviço.

//O nível de escolaridade dos candidtos, considerando ensino fundamental, ensino médio, ensino superior e pós-graduação.

//Faça um algoritmo para calcular e apresentar as informações mencionadas, sendo que, a cada
//iteraçáo deve ser perguntado ao usuário se ele deseja cadastrar outro candidato, encerrando o programa, se a resposta for negativa.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

string op, nome, sexo, escolaridade, experiencia;
int idade, cont_fem = 0, cont_masc = 0, masc_experiencia = 0, fem_experiencia = 0, porcentagem_masc = 0, idade_menor = 0, idade_fem = 0, idade_masc = 0, soma_fem = 0, soma_masc = 0, media_exp_fem, media_exp_masc, ens_fund = 0, ens_medio = 0, grad = 0, pos_grad = 0;


do
{

    Console.WriteLine("===================CADASTRO===================");
    Console.WriteLine("Complete com as informações necessárias abaixo: ");

    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Sexo: (feminino/masculino) ");
    sexo = Console.ReadLine();

    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Nível de escolaridade: ");
    Console.WriteLine("Ensino Fundamental" + "\n" + "Ensino médio" + "\n" + "Ensino superior" + "\n" + "Pós Graduação");
    escolaridade = Console.ReadLine();

    Console.Write("Possui alguma experiência? ");
    experiencia = Console.ReadLine();

    Console.Clear();

    

    if (sexo == "feminino")
    {
        cont_fem++;
        idade_fem = idade;
        soma_fem = soma_fem + idade_fem;

        if (experiencia == "sim")
        {
           
            fem_experiencia++;

            if (idade_menor < idade)
            {
                idade_menor = idade;
            }
            
        }

    }

    else
    {
        cont_masc++;
        idade_masc = idade;
        soma_masc = soma_masc + idade_masc;

        if (experiencia == "sim")
        {
            masc_experiencia++;
        }

        if (idade >= 35 && idade <= 45)
        {
            porcentagem_masc++;
        }

    }

    if (escolaridade == "Ensino Fundamental")
    {
        ens_fund++;
    }

    else if (escolaridade == "Ensino médio")
    {
        ens_medio++;
    }

    else if (escolaridade == "Ensino superior")
    {
        grad++;
    }

    else if (escolaridade == "Pós Graduação")
    {
        pos_grad++;
    }

    Console.WriteLine("Deseja cadastrar outro usuário? (sim/não)");
    op = Console.ReadLine();

} while (op == "sim");


media_exp_fem = soma_fem / cont_fem;
media_exp_masc = soma_masc / cont_masc;

porcentagem_masc = (porcentagem_masc * 100) / cont_masc;


Console.WriteLine("===================INFORMAÇÕES DOS CANDIDATOS===================");

//O número de candidatos do sexo feminino. 
Console.WriteLine("Sexo feminino: " + cont_fem + " candidatas");

//O número de candidatos do sexo masculino.
Console.WriteLine("Sexo masculino: " + cont_masc + " candidatos");

//A idade média dos homens com experiência.
Console.WriteLine("Idade média entre os homens com experiência: " + media_exp_masc);

//A idade média das mulheres com experiência.
Console.WriteLine("Idade média entre as mulheres com experiência: " + media_exp_fem);

//A percentagem dos homens entre 35 e 45 anos, entre o total dos homens.
Console.WriteLine("Porcentagem de homem com idade de 35 a 45 anos: " + porcentagem_masc);

//A menor idade entre as mulheres que ja têm experiencia no serviço.
Console.WriteLine("Menor idade entre as mulheres com experiência: " + idade_menor);

//O nível de escolaridade dos candidtos, considerando ensino fundamental, ensino médio, ensino superior e pós-graduação.
Console.WriteLine("Nível de escolaridade dos candidatos: ");
Console.WriteLine(ens_fund + " candidatos com nível de ensino Fundamental");
Console.WriteLine(ens_medio + " candidatos com o nível de ensino Médio");
Console.WriteLine(grad + " candidatos com o nível de ensino Graduação");
Console.WriteLine(pos_grad + " candidatos com o nível de ensino Pós-Graduação");


Console.ReadKey();