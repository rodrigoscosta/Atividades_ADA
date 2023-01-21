using System;

class Chacal : Mamifero
{
  public Chacal()
  {
    Nome = "Chack";
    DataNascimento = new DateTime(1997, 02, 07);
    Sexo = 'F';
    Carnivoro = true;
    Peconhento = false;

    QtdMamas = 4;
    Pelos = true;
    CorDoPelo = "Marrom e Preto";

    Movimentar();
    Comunicar();
    Alimentar();
  }
}