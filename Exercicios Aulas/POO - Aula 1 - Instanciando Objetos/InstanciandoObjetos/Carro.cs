public class Carro(string fabricante, string modelo, int anoFab, string anoMod, float valor, string combustivel, string cilindrada, int potencia)
{
    public string Fabricante = fabricante;
    public string Modelo = modelo;
    public int AnoFab = anoFab;
    public string AnoMod = anoMod;
    public float Valor = valor;

    public Motor MotorCarro = new Motor(combustivel, cilindrada, potencia);
    public float IPVA = anoFab > 2006 ? valor * (4f/100f): 0f;
    public override string ToString()
    {
        Console.WriteLine("\n\n");
        return $"Fabricante: {this.Fabricante} \nModelo: {this.Modelo} \nAno de Fabricação: {this.AnoFab} \n" +
            $"Ano de Modelo: {this.AnoMod} \nValor: R${this.Valor:F2}\nValor do IPVA: R${IPVA:F2}" +
            $"\n-Dados do Motor-\nCombustivel: {MotorCarro.Combustivel}\nCilindrada: {MotorCarro.Cilindrada}\n" +
            $"Potência: {MotorCarro.Potencia}cv";
    }

    public class Motor(string combustivel, string cilindrada, int potencia)
    {
        public string Combustivel = combustivel;
        public string Cilindrada = cilindrada;
        public int Potencia = potencia;
    }
        
}

public static class Teste
    {
    public static void teste()
    {
        Console.WriteLine("teste");
    }
    }

