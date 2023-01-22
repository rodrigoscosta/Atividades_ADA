using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Celular celular = new Celular();
    Camera camera = new Camera();

            char resposta;
            bool sucesso;
            do
            {
                Console.Clear();
                Console.WriteLine("CAMERA\n");

                Console.WriteLine($"Espaço disponivel: {celular.EspacoDisponivel} fotos\n");

                Console.WriteLine("Gostaria de Tirar Fotos?");

                do
                {
                    Console.Write("Digte S para SIM ou QUALQUER outra tecla para NÃO: ");
                    sucesso = char.TryParse(Console.ReadLine().ToUpper(), out resposta);

                    if (!sucesso)
                    {
                        Console.WriteLine("Por Favor, Digite Apenas Uma Tecla Para Responder\n");
                    }

                } while (!sucesso);

                if (resposta == 'S')
                {
                    if (celular.EspacoDisponivel >= 1)
                    {
                        int qtdFotos;
                        do
                        {
                            Console.Write("\nGostaria de Tirar Quantas Fotos: ");
                            int.TryParse(Console.ReadLine(), out qtdFotos);

                            if (qtdFotos < 1 || qtdFotos > celular.EspacoDisponivel)
                            {
                                Console.WriteLine($"Quantidade invalida, tente tirar de 1 a {celular.EspacoDisponivel} fotos\n");
                            }

                        } while (qtdFotos < 1 || qtdFotos > celular.EspacoDisponivel);

                        Console.WriteLine("\nCamera Frontal ou Traseira?");
                        do
                        {
                            Console.Write("Digte F para FRONTAL e T para TRASEIRA: ");
                            char.TryParse(Console.ReadLine().ToUpper(), out resposta);

                            if (resposta != 'F' && resposta != 'T')
                            {
                                Console.WriteLine("Opção Invalida\n");
                            }

                        } while (resposta != 'F' && resposta != 'T');

                        Console.Clear();

                        switch (resposta)
                        {
                            case 'F':
                                CameraFrontal cameraFrontal = new CameraFrontal();

                                Console.WriteLine("Camera Frontal Selecionada\n");
                        
                                Console.WriteLine($"Resolução Maxima: {cameraFrontal.ResolucaoMaxima}MP");
                                Console.WriteLine($"Resolução Atual: {cameraFrontal.ResolucaoAtual}MP");
                                Console.WriteLine($"\nTirando {qtdFotos} Fotos...");
                                cameraFrontal.TirarFoto(qtdFotos);
                                celular.TirarEspaco(qtdFotos);
                                break;

                            case 'T':
                                CameraTraseira cameraTraseira = new CameraTraseira();

                                Console.WriteLine("Camera Traseira Selecionada\n");
                                Console.WriteLine($"Resolução Maxima: {cameraTraseira.ResolucaoMaxima}MP");
                                Console.WriteLine($"Resolução Atual: {cameraTraseira.ResolucaoAtual}MP");
                                Console.WriteLine($"\nTirando {qtdFotos} Fotos...");
                                cameraTraseira.TirarFoto(qtdFotos);
                                celular.TirarEspaco(qtdFotos);
                                break;
                        }

                        resposta = 'S';
                    }
                    else
                    {
                        Console.WriteLine("\nSem Espaço Disponivel");
                        Console.WriteLine("Fechando Camera...");
                        resposta = 'F';
                    }
                }

            } while (resposta == 'S');
  }
}