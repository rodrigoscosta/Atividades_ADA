namespace API_Eventos.Interfaces
{
    public interface ICityEvent
    {
        List<CityEvent> ConsultarEventos();
        List<CityEvent> ConsultarEventoTitulo(string title);
        List<CityEvent> ConsultarEventoDataELocal(DateTime dateHourEvent, string local);
        List<CityEvent> ConsultarEventoPrecoEData(decimal low, decimal high, DateTime dateHourEvent);
        bool InserirEvento(CityEvent cityEvent);
        bool AtualizarEvento(CityEvent cityEvent);
        bool DeletarEvento(long id);
    }
}