int[] nums;

nums = new int[5];

void RegistraNumeros()
{
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"Insira o valor da posição {i}: ");
        nums[i] = int.Parse(Console.ReadLine());

    }
}
void ImprimeNumeros()
{
    Console.Write("Ordem normal: ");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"[{nums[i]}] ");
    }
    
}
void InverterNumeros(int[] ints)
{
    Console.Write("\nOrdem inversa: ");
    for (int i = ints.Length - 1; i >= 0; i--)
    {
        Console.Write($"[{ints[i]}] ");
    }
}

void Pares(int[] ints)
{
    Console.Write("\nPares: ");
    int contador = 0;
    
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] % 2 == 0) contador++;

    }
    int[] pares = new int[contador];

    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] % 2 == 0) {
            pares[contador-1] = ints[i];
            contador--;
            Console.Write($"[{pares[contador]}] ");
        }
        
    }
}

void Impares(int[] ints)
{
    Console.Write("\nImpares: ");
    int contador = 0;

    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] % 2 != 0) contador++;

    }
    int[] impares = new int[contador];
   
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] % 2 != 0)
        {
            impares[contador - 1] = ints[i];
            contador--;
            Console.Write($"[{impares[contador]}] ");
        }

    }
}

RegistraNumeros();
ImprimeNumeros();
InverterNumeros(nums);
Pares(nums);
Impares(nums);