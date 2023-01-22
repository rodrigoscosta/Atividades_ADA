using System;

abstract class Livro
{
  private string Autor { get; set; }
  private int Ano { get; set; }

  public Livro(string autor, int ano)
  {
    Autor = autor;
    Ano = ano;
  }
}