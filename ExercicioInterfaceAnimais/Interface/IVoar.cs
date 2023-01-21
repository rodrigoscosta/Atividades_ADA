public interface IVoar
{
  public int AltitudeMaximaEmMetros { get; set; }
  public double VelocidadeDoVoo { get; set; }

  public void Voar();
}