float salario, aumento;

salario = 0f;
aumento = 0f;

Console.Write("Informe o seu salário: ");
salario = float.Parse(Console.ReadLine());
Console.WriteLine($"O seu salário atual é: R${salario}");

switch (salario)
{
    case < 0:
        Console.WriteLine("Você paga pra trabalhar?");
        break;
    case <= 2000f:
        aumento = 12f / 100f;
        salario += salario * aumento;
        Console.WriteLine($"Você teve um aumento de 12%\nO seu salario atual é: R${salario}");
        break;
    case <= 4000f:
        aumento = 10f / 100f;
        salario += salario * aumento;
        Console.WriteLine($"Você teve um aumento de 10%\nO seu salario atual é: R${salario}");
        break;
    case > 4000f:
        aumento = 5f / 100f;
        salario += salario * aumento;
        Console.WriteLine($"Você teve um aumento de 5%\nO seu salario atual é: R${salario}");
        break;
}
