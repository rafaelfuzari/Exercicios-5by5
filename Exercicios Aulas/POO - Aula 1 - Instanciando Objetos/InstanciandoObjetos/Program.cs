Carro c1 = new Carro("Renault", "Kwid", "2026", "2027", 94000.00f);
Carro c2 = new Carro("Nissan", "Versa", "2015", "2015", 47000.00f);
Carro c3 = new Carro("Honda", "Civic", "2022", "2021", 115000.00f);
Carro c4 = new Carro("Volkswagen", "Gol G5", "2017", "2017", 38000.00f);


Carro[] cArray = new Carro[] { c1, c2, c3, c4 };

for (int i = 0; i < cArray.Length; i++)
{
    Console.WriteLine(cArray[i]);
}



