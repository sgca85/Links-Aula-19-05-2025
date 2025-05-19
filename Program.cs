using System.Diagnostics;

string tecla = "";
string menu = @"----
Menu
A - Abrir arquivo
S - Sair
----";
do
{
    Console.Clear();
    Console.WriteLine(menu);
    Console.Write("Digite: ");
    tecla = Console.ReadLine()!;

    switch (tecla)
    {
        case "A":
            Console.WriteLine("Abrindo arquivo...");
            break;
        case "S":
            Console.WriteLine("Obrigado! Volte novamente");
            break;
        default:
            Console.WriteLine("Opção inválida!!");
            break;
    }
    Console.Write("Digite uma tecla para continuar...");
    Console.ReadKey(true);
}
while (tecla != "S");

// string resposta = "";
// Console.WriteLine("Você deseja sair do programa?");
// resposta = Console.ReadLine()!.ToUpper().Substring(0,1);

// while (resposta != "S")
// {
//     Console.WriteLine("Continuando...");
//     Console.WriteLine("Você deseja sair do programa?");
//     resposta = Console.ReadLine()!.ToUpper().Substring(0,1);
// }

// Console.WriteLine("Saindo...");

// Console.Clear();
// int contador = 1;

// while (contador <= 10)
// {
//     Console.Write($"{contador++} ");
// }


// while(true)
// {
//     Console.WriteLine("Laço infinito");
// }