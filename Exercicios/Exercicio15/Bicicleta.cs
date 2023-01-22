class Bicicleta : Veiculo
{
  private bool Infantil { get; set; }
  
  public Bicicleta(bool usaCombustivel, int rodas) : base(usaCombustivel, rodas) 
  {
    if (rodas > 2)
    {
      Infantil = true;
    }
    else
    {
      Infantil = false;
    }
  }
}