using System;

class Ebook : Livro
{
  public int NumPaginas { get; set; }
  public int NumCapitulos { get; set; }

  public Ebook(string autor, int ano) : base(autor, ano)
  {
    Random random = new Random();

    NumPaginas = random.Next(100, 501);
    Console.WriteLine($"Numero de Paginas: {NumPaginas}");

    NumCapitulos = random.Next(1, 21);
    Console.WriteLine($"Numero de Capitulos: {NumCapitulos}");
  }
}