using System.ComponentModel;

public abstract class ContaBancaria
{
    public int Numero { get; set; }
    public double Saldo { get; set; }
    public ContaBancaria(int numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }

    public virtual void Transferir(ContaBancaria obj)
    {
        Console.Write("Digite o valor a ser transferido: ");
        double valor = double.Parse(Console.ReadLine());

        if (Saldo <= Saldo - valor)
        {
            Saldo -= valor;
            obj.Saldo += valor;
        }
        else Console.WriteLine("Saldo insuficiente, pobre!");
        
    }
    public void Depositar()
    {
        Console.WriteLine("Digite o valor a ser depositado: ");
        double valor = double.Parse(Console.ReadLine());

        Saldo += Math.Abs(valor);
    }

    public virtual void Sacar()
    {
        Console.WriteLine("Digite o valor a ser sacado: ");
        double valor = double.Parse(Console.ReadLine());

        if (Saldo - valor >= 0) Saldo -= Math.Abs(valor);
        else Console.WriteLine("Saldo insuficiente, pobre!");
    }

    public virtual void Pagar()
    {
        Console.WriteLine("Digite o valor da conta a pagar: ");
        double valor = double.Parse(Console.ReadLine());

        if (Saldo - valor >= 0) Saldo -= Math.Abs(valor);
        else Console.WriteLine("Saldo insuficiente, pobre!");
    }

    public string MostrarTipoConta()
    {
        return base.ToString();
    }
    public override string ToString()
    {
        return "\n" + base.ToString() + $"\n\nNúmero: {Numero}\nSaldo: R${Saldo:F2}";
    }
}
public class ContaCorrente : ContaBancaria
{
        public double Limite { get; set; }
        public ContaCorrente(int numero, double saldo) : base(numero, saldo)
        {
            Limite = saldo * 3;
            this.Numero = numero;
            this.Saldo = saldo;
        }
    public override void Transferir(ContaBancaria obj)
    {
        Console.Write("Digite o valor a ser transferido: ");
        double valor = double.Parse(Console.ReadLine());

        if (Saldo <= (Saldo + Limite) - valor)
        {
            Saldo -= valor;
            obj.Saldo += valor;
            AtualizarLimite();
        }
        else Console.WriteLine("Saldo insuficiente, pobre!");

    }
    public void AtualizarLimite()
    {
        if (Saldo > 0) Limite = this.Saldo * 3;
        else Limite = 0;
    }

    public override void Pagar()
    {
        Console.WriteLine("Digite o valor da conta a pagar: ");
        double valor = double.Parse(Console.ReadLine());

        if (Saldo + this.Limite - valor >= 0) Saldo -= Math.Abs(valor);
        else Console.WriteLine("Saldo e limite insuficiente, pobre!");
        AtualizarLimite();

    }

    public override void Sacar()
    {
        Console.WriteLine("Digite o valor a ser sacado: ");
        double valor = double.Parse(Console.ReadLine());

        if (Saldo+Limite - valor >= 0) Saldo -= Math.Abs(valor);
        else Console.WriteLine("Saldo insuficiente, pobre!");
        AtualizarLimite();
    }

    public void MostrarLimite()
    {
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nLimite: R${Limite}";
    }
}

public class ContaSalario : ContaBancaria
{
    public double Taxa { get; set; }
    public ContaSalario(int numero, double saldo) : base(numero, saldo)
    {
        Taxa = 5f / 100f;
        this.Numero = numero;
        this.Saldo = saldo;
    }

    public override void Sacar()
    {
        Console.WriteLine("Digite o valor a ser sacado: ");
        double valor = double.Parse(Console.ReadLine());

        double valorTaxado = valor + (valor * Taxa);
        
        if (Saldo - valorTaxado >= 0)
        {
            Saldo -= Math.Abs(valorTaxado);
            Console.WriteLine($"Foi cobrado R${valor * this.Taxa:F2} de taxa");
        }
        else Console.WriteLine("Saldo insuficiente, pobre! Lembre-se que é cobrado uma taxa de 5%!");
    }
    
}

public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(int numero, double saldo) : base(numero, saldo)
    {
        this.Numero = numero;
        this.Saldo = saldo;
    }
}

