int numero;
int[] arrayFib;

numero = 0;


Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine());

arrayFib = new int[numero];

void RegistraFib()
{
    if (numero > 0)
    {
        arrayFib[0] = 0;
    }
    else Console.WriteLine("o número tem que ser maior que zero");

    if (numero > 1)
    {
        arrayFib[1] = 1;
        for (int i = 2; i < numero; i++)
        {

            arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];

        }
    }
}

void ImprimeFib(int[] fib) {
    for (int i = 0; i < arrayFib.Length; i++)
    {
        Console.Write($"[{fib[i]}] ");
    }
}

RegistraFib();
ImprimeFib(arrayFib);