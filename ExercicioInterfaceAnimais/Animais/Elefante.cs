using System;

public class Elefante : Mamifero
{
  public Elefante()
  {
    Nome = "Ellie";
    DataNascimento = new DateTime(2027, 10, 12);
    Sexo = 'F';
    Carnivoro = false;
    Peconhento = false;

    QtdMamas = 2;
    Pelos = true;
    CorDoPelo = "Cinza";
    
    Movimentar();
    Comunicar();
    Alimentar();
  }
}