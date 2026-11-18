public class Senha
{
    public string Valor { get; set; }
    public Senha Prox { get; set; }

    public Senha()
    {
        Valor = string.Empty;
        Prox = null;
    }

    public void GerarSenha(string t)
    {
        t.ToUpper();
        if (t.Equals("P"))
        {
            Valor = $"{t}:{Random.Shared.Next(1, 500)}";
        }
        if (t.Equals("N"))
        {
            Valor = $"{t}:{Random.Shared.Next(1, 500)}";
        }
        
    }
}