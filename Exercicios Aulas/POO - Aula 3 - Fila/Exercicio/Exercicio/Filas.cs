public abstract class Fila
{
    public Senha Head { get; set; }

    public Senha Tail { get; set; }
    public int Contador { get; set; }

    public Fila()
    {
        Head = null;
        Tail = null;
        Contador = 0;

    }
    public bool Vazio()
    {
        if (Head == null && Tail == null) return true;
        else return false;
    }

    public void Inserir(Senha obj)
    {
        if (!Vazio())
        {
            Tail.Prox = obj;
            Tail = obj;

        }else
        {
            Head = obj;
            Tail = obj;
        }

        Contador++;
    }

    public void Imprimir()
    {
        Senha s = Head;
        for (int i = 0; i < Contador; i++)
        {
            Console.WriteLine(s.Valor);
            s = s.Prox;
        }
    }

    public void Retirar()
    {
        if (!Vazio() && Head.Prox != null){

            Head = Head.Prox;
            Contador--;
        } else if (!Vazio())
        {
            Head = null;
            Tail = null;
            Contador--;
        }
    }


}

public class FilaPadrao : Fila
{

}

public class FilaPrioritaria : Fila
{

}

