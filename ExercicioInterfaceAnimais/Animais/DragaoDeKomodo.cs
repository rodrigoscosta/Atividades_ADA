using System;

public class DragaoDeKomodo : Reptil, IOviparo
{
  public void Botar()
  {
    Console.WriteLine("O DragÃO de Komodo está botando ovos!");
    Console.WriteLine();
  }
  
  public void Chocar()
  {
    Console.WriteLine("Os ovos dos Dragões de Komodo levam 20 dias para chocarem!");
    Console.WriteLine();
  }

  public DragaoDeKomodo()
  {
    Nome = "Lambert";
    DataNascimento = new DateTime(1871, 02, 10);
    Sexo = 'M';
    Carnivoro = true;
    Peconhento = true;

    TemEscamas = true;
    TemCasco = false;

    Botar();
    Chocar();
    Console.WriteLine();
    
    Movimentar();
    Comunicar();
    Alimentar();
  }
}