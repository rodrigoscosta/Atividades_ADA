using API_Eventos.Interfaces;

public class CityEventService : ICityEvent
{
    public ICityEvent _cityEvent;
    public IEventReservation _eventReservation;

    public CityEventService(ICityEvent cityEvent, IEventReservation eventReservation)
    {
        _cityEvent = cityEvent;
        _eventReservation = eventReservation;
    }

    public List<CityEvent> ConsultarEventos()
    {
        return _cityEvent.ConsultarEventos();
    }

    public List<CityEvent> ConsultarEventoTitulo(string title)
    {
        return _cityEvent.ConsultarEventoTitulo(title);
    }
    public List<CityEvent> ConsultarEventoDataELocal(DateTime dateHourEvent, string local)
    {
        return _cityEvent.ConsultarEventoDataELocal(dateHourEvent, local);
    }
    public List<CityEvent> ConsultarEventoPrecoEData(decimal low, decimal high, DateTime dateHourEvent)
    {
        return _cityEvent.ConsultarEventoPrecoEData(low, high, dateHourEvent);
    }

    public bool InserirEvento(CityEvent cityEvent)
    {
        return _cityEvent.InserirEvento(cityEvent);
    }

    public bool AtualizarEvento(CityEvent cityEvent)
    {
        return _cityEvent.AtualizarEvento(cityEvent);
    }

    public bool DeletarEvento(long idEvent)
    {
        var eventReservationList = _eventReservation.ConsultarReservas().ToList();
        if (!eventReservationList.Any(x => x.IdEvent == idEvent))
        { 
            return _cityEvent.DeletarEvento(idEvent);
        }
        var cityEventList = _cityEvent.ConsultarEventos().ToList();
        var active = cityEventList.FirstOrDefault(x => x.IdEvent == idEvent);
        active.Status = false;
        return _cityEvent.AtualizarEvento(active);
    }
}