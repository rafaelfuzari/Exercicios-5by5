public class Livro
{
    public string Titulo;
    public string Autor;
    public int Pags;
    public Livro(string titulo, string autor, int pags)
    {
        Titulo = titulo;
        Autor = autor;
        Pags = Math.Abs(pags);
    }

    public string GetTitulo()
    {
        return Titulo;
    }
    public string GetAutor()
    {
        return Autor;
    }

    public int GetPags()
    {
        return Pags;
    }

    public override string ToString()
    {
        return $"Titulo: {Titulo};\nAutor: {Autor};\nPáginas: {Pags}";
    }
}

