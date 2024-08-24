//Calculadora

using System;

namespace Calcualdora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


static void ExibirLogo()
{
    string msg = "\nBoas vindas a Calculadora";
    Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░██║██║░░██║██████╔╝███████║
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝");
    Console.WriteLine(msg);
}

static void Menu()
{

    ExibirLogo();
    Console.WriteLine("\n1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair da aplicação");

    Console.Write("\nEscolha a Opção que deseja seguir: ");
    //string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Somar();
            break;
        case 2:
            Subtrair();
            break;
        case 3:
            Divisao();
            break;
        case 4:
            Multiplicacao();
            break;
        case 5:
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Operação Invalida !!");
            break;
    }
}

static void Somar()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("\nDigite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine()!);
    float soma = v1 + v2;
    Console.WriteLine($"\n {v1} + {v2} = {soma}");
}

static void Subtrair()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("\nDigite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine()!);
    float menos = v1 - v2;
    Console.WriteLine($"\n {v1} - {v2} = {menos}");
}

static void Divisao()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("\nDigite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine()!);
    float dividir = v1 / v2;
    Console.WriteLine($"\n {v1} / {v2} = {dividir}");
}

static void Multiplicacao()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("\nDigite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine()!);
    float multiplicacao = v1 * v2;
    Console.WriteLine($"\n {v1} * {v2} = {multiplicacao}");
}

    }
}