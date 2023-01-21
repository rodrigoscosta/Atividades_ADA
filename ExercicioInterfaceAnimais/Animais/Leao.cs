using System;

public class Leao : Mamifero
{
  public Leao()
  {
    Nome = "Scar";
    DataNascimento = new DateTime(2003, 02, 11);
    Sexo = 'M';
    Carnivoro = true;
    Peconhento = false;

    QtdMamas = 6;
    Pelos = true;
    CorDoPelo = "Amarelo alaranjado";

    Amamentar();
    Movimentar();
    Comunicar();
    Alimentar();
  }
}