char[] arrayMenor =  new char[10];
int[] arrayAscii = new int[10];
string[] arrayMaior = new string[20];
int aux = 0;

void RegistraArray()
{
    for(int i = 0; i < arrayMenor.Length; i++){
        Console.Write("Insira um char: ");
        arrayMenor[i] = char.Parse(Console.ReadLine());
    }
}

void RegistraArrayAscii()
{
    for (int i = 0; i < arrayAscii.Length; i++)
    {
        arrayAscii[i] = arrayMenor[i];
    }
}

void fusaoArray(char[] arrayChar, int[] ascii)
{
    for (int i = 0; i < 10; i++)
    {
        arrayMaior[aux] = char.ToString(arrayChar[i]);
        arrayMaior[aux+1] = Convert.ToString(ascii[i]);
        aux += 2;
    }

}

void imprimeResultado(string[] resultado)
{
    for (int i = 0; i < resultado.Length; i++)
    {
        Console.Write($"[{resultado[i]}] ");
    }

}

RegistraArray();
RegistraArrayAscii();
fusaoArray(arrayMenor, arrayAscii);
imprimeResultado(arrayMaior);
