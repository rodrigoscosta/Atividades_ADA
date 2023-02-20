using API_Eventos.Interfaces;

public class EventReservationService : IEventReservation
{
    public IEventReservation _eventReservation;
    public EventReservationService(IEventReservation eventReservation)
    {
        _eventReservation = eventReservation;
    }

    public List<EventReservation> ConsultarReservas()
    {
        return _eventReservation.ConsultarReservas();
    }

    public List<EventReservation> ConsultarReservaPersonNameETitle(string personName, string title)
    {
        return _eventReservation.ConsultarReservaPersonNameETitle(personName, title);
    }

    public bool InserirReserva(EventReservation eventReservation)
    {
        return _eventReservation.InserirReserva(eventReservation);
    }
    public bool AtualizarReserva(long reservationId, long quantity)
    {

        return _eventReservation.AtualizarReserva(reservationId, quantity);
    }
    public bool DeletarReserva(long idReservation)
    {
        return _eventReservation.DeletarReserva(idReservation);
    }
}