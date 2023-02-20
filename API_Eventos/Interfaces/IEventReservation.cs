namespace API_Eventos.Interfaces
{
    public interface IEventReservation
    {
        List<EventReservation> ConsultarReservas();
        List<EventReservation> ConsultarReservaPersonNameETitle(string personName, string title);
        bool InserirReserva(EventReservation eventReservation);
        bool AtualizarReserva(long idReservation, long quantity);
        bool DeletarReserva(long idReservation);
    }
}