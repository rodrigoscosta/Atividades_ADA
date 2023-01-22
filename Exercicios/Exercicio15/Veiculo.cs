abstract class Veiculo
{
  private bool UsaCombustivel { get; set; }
  private int Rodas { get; set; }

  public Veiculo(bool usaCombustivel, int rodas)
  {
    UsaCombustivel = usaCombustivel;
    Rodas = rodas;
  }
}