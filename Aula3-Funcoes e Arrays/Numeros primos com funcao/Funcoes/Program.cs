int numero;
bool EPrimo(int numero)
{
    int divisores = 0;
    if (numero <= 1) return false;
    for (int i = 2; i <= numero; i++)
    {
        if (numero % i  == 0) {
            divisores++;
        }
        
    }
    if (divisores > 1)
        return false;
    else return true;
}
numero = int.Parse(Console.ReadLine());

if (numero > 2)
{
    for (int i = 2; i <= numero; i++)
    {
        if (EPrimo(i)) Console.WriteLine($"O {i} é primo");
        else Console.WriteLine($"O {i} não é primo");
    }
}