int idade;

idade = 0;

Console.Write("Insira sua idade: ");
idade = int.Parse(Console.ReadLine());

switch (idade)
{
    case < 0:
        Console.WriteLine("NÃO EXISTE IDADE NEGATIVAAAAAAAA!");
        break;

    case <= 12:
        Console.WriteLine("Você é uma criança");
        break;

    case <= 17:
        Console.WriteLine("Você é um adolescente");
        break;

    case <= 59:
        Console.WriteLine("Você é um adulto");
        break;

    case >= 60:
        Console.WriteLine("Você é um idoso");
        break;
}
