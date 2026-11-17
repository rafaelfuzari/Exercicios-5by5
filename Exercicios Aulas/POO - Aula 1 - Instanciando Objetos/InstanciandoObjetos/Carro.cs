public class Carro(string fabricante, string modelo, int anoFab, string anoMod, float valor)
{
    public string Fabricante = fabricante;
    public string Modelo = modelo;
    public int AnoFab = anoFab;
    public string AnoMod = anoMod;
    public float Valor = valor;

    public float IPVA = anoFab > 2006 ? valor * (4f/100f): 0f;
    public override string ToString()
    {
        Console.WriteLine("\n\n");
        return $"Fabricante: {this.Fabricante}; \nModelo: {this.Modelo}; \nAno de Fabricação: {this.AnoFab} \nAno de Modelo: {this.AnoMod} \nValor: R${this.Valor:F2}\nValor do IPVA: R${IPVA:F2}";
    }

    
}


