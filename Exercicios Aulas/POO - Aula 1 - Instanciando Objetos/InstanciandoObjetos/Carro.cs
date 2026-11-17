public class Carro(string fabricante, string modelo, string anoFab, string anoMod, float valor, Motor motor)
{
    public string Fabricante = fabricante;
    public string Modelo = modelo;
    public string AnoFab = anoFab;
    public string AnoMod = anoMod;
    public float Valor = valor;
    public Motor MotorCarro = new Motor("Gasolina", 280, 79);
    public override string ToString()
    {
        Console.WriteLine("\n\n");
        return $"Fabricante: {this.Fabricante}; \nModelo: {this.Modelo}; \nAno de Fabricação: {this.AnoFab} \nAno de Modelo: {this.AnoMod} \nValor: R${this.Valor:F2}";
    }

    public class Motor()
    {
        public Motor(string combustivel, int cilindrada, int potencia) {
        public string Combustivel = combustivel;
        public int Cilindrada = cilindrada;
        public int Potencia = potencia;
    }
    }
}

