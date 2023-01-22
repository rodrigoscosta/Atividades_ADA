using System;

class Time
{
  public string Pais { get; set; }
  public string Esporte { get; set; }
  public int Pontuacao { get; set; }

  public Time()
  {
    Pontuacao = 0;
  }

  public void Pontuar(char resultado)
  {
    switch (resultado)
    {
      case 'W':
        Pontuacao += 3;
      break;

      case 'D':
        Pontuacao += 1;
      break;
    }
  }
}