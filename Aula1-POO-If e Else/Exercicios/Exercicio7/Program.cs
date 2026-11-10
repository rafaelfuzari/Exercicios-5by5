float peso, altura, imc;

peso = 0f;
altura = 0f;
imc = 0f;

Console.Write("Digite seu peso em kg: ");
peso = float.Parse(Console.ReadLine());

Console.Write("Digite sua altura em cm: ");
altura = float.Parse(Console.ReadLine());

imc = peso / ((altura / 100) * (altura / 100));

Console.WriteLine($"Seu IMC é: {imc}");

switch (imc)
{
    case <= 0:
        Console.WriteLine("Você fez algo errado!");
        break;
    case < 18.5f:
        Console.WriteLine("Você está abaixo do peso");
        break;
    case < 24.9f:
        Console.WriteLine("Você está no seu peso normal");
        break;
    case < 29.9f:
        Console.WriteLine("Você está sobrepeso");
        break;
    case < 34.9f:
        Console.WriteLine("Você está com Obesidade Grau I");
        break;
    case < 39.9f:
        Console.WriteLine("Você está com Obesidade Grau II");
        break;
    default:
        Console.WriteLine("Você está com Obesidade Grau III");
        break;
}

