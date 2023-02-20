public interface IEventReservationRepository
{
    List<EventReservation> SelecionarReservas();
    List<EventReservation> SelecionarReservaPersonNameETitle(string personName, string title);
    bool CriarReserva(EventReservation eventReservation);
    bool AlterarReserva(long idReservation, long quantity);
    bool RemoverReserva(long idReservation);
}