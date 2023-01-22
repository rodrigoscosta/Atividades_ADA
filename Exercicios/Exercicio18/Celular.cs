using System;

class Celular
{
  public int EspacoDisponivel { get; set; }
  public int CameraFrontal { get; set; }
  public int CameraTraseira { get; set; }
  
  public Celular()
  {
    EspacoDisponivel = 100;
  }

  public void TirarEspaco(int qtdFotos) 
  {
    EspacoDisponivel -= qtdFotos;
  }
}