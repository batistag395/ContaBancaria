using Banco;
using System.Globalization;

Conta conta;

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o numero da conta: ");
int contaNum = int.Parse(Console.ReadLine());

Console.Write("Havera deposito inicial? s/n: ");
char resposta = char.Parse(Console.ReadLine());

if (resposta == 's' || resposta == 'S')
{
    Console.Write("Valor do deposito inicial: ");
    double depositar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new Conta(nome, contaNum, depositar);
}
else
{
    conta = new Conta(nome, contaNum);
}

Console.WriteLine("");
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.Write("Valor do deposito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);

Console.WriteLine();
Console.WriteLine($"Dados Atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Valor do saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);

Console.WriteLine();
Console.WriteLine("Dados Atualizados: ");
Console.WriteLine(conta);



