namespace API_Eventos.Interfaces
{
    public interface ICityEventRepository
    {
        List<CityEvent> SelecionarEventos();
        List<CityEvent> SelecionarEventoTitulo(string title);
        List<CityEvent> SelecionarEventoDataELocal(DateTime dateHourEvent, string local);
        List<CityEvent> SelecionarEventoPrecoEData(decimal low, decimal high, DateTime dateHourEvent);
        bool CriarEvento(CityEvent cityEvent);
        bool AlterarEvento(CityEvent cityEvent);
        bool RemoverEvento(long id);
    }
}