class Camera
{
  public double ResolucaoMaxima { get; set; }
  public int FotosTiradas { get; set; }

  public Camera()
  {
    FotosTiradas = 0;
  }
  
  public void TirarFoto(int qtdFotos)
  {
    FotosTiradas += qtdFotos;         
  }
}