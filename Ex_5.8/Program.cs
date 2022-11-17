// 8.realiza a soma dos números digitados, até que o usuário encerre o programa,
// usando uma das estruturas de laço e fazendo a pergunta: Deseja continuar?
// Preferencialmente, tente usar uma resposta em formato literal.


int num = 0;
string op;
int soma = 0;


do
{
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());

    soma = num + soma;

    Console.WriteLine("A Soma dos números digitados é: " + soma);


    Console.WriteLine("Deseja continuar? (sim/não)");
    op = Console.ReadLine();


} while (op == "sim");


Console.ReadKey();






