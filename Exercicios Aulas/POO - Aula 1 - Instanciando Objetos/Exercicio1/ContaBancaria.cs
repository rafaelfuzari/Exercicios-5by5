public class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public ContaBancaria(string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public void Depositar(double valor)
    {
        Saldo += Math.Abs(valor);
    }
    public void Sacar(double valor)
    {
        if (Saldo - valor > 0) Saldo -= Math.Abs(valor);
        else Console.WriteLine("Saldo insuficiente para esse saque");
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Seu saldo é de: R${Saldo:F2}");
    }

    public override string ToString()
    {
        return $"Titular: {Titular};\nSaldo: R${Saldo:F2}";
    }

}

