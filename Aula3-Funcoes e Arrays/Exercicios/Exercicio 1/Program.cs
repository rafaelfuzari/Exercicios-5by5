int[] nums;

nums = new int[6];

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
    Console.Write("\nOrdem inversa: ");
    for (int i = nums.Length -1; i >= 0; i--)
    {
        Console.Write($"[{nums[i]}] ");
    }
}

RegistraNumeros();
ImprimeNumeros();