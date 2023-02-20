using Dapper;
using MySqlConnector;

public class EventReservationRepository
{
    private string _stringConnection = Environment.GetEnvironmentVariable("DATABASE_CONFIG");

    public List<EventReservation> ConsultarReservaPersonNameETitle(string personName, string title)
    {
        string query = "SELECT EventReservation.idEvent, EventReservation.personName, EventReservation.quantity " +
                "FROM EventReservation INNER JOIN CityEvent ON EventReservation.idEvent = CityEvent.idEvent " +
                "WHERE EventReservation.personName = @personName AND CityEvent.title LIKE @title";

        DynamicParameters parameters = new();
        parameters.Add("personName", personName);
        parameters.Add("title", "%" + title + "%");

        using MySqlConnection connection = new(_stringConnection);

        return  connection.Query<EventReservation>(query, parameters).ToList();
    }

    public bool InserirReserva(EventReservation eventreservation)
    {            
        string query = "INSERT INTO EventReservation (idEvent, personName, quantity)" +
                "VALUES (@idEvent, @personName, @quantity)";

        DynamicParameters parameters = new(eventreservation);

        CityEventRepository cityEvent = new();

        int linhasAfetadas = 0;

        using MySqlConnection connection = new(_stringConnection);

        linhasAfetadas = connection.Execute(query, parameters);                              

        return linhasAfetadas > 0;
    }

    public bool AtualizarReserva(long idReservation, int quantity)
    {
        string query = "UPDATE EventReservation SET quantity = @quantity WHERE idReservation = @idReservation";

        DynamicParameters parameters = new();
        parameters.Add("quantity", quantity);
        parameters.Add("idReservation", idReservation);

        using MySqlConnection connection = new(_stringConnection);

        int linhasAfetadas = connection.Execute(query, parameters);

        return linhasAfetadas > 0;
    
    }

    public bool DeletarReserva(long idReservation)
    {
        string query = "DELETE FROM EventReservation WHERE idReservation = @idReservation";

        DynamicParameters parameters = new();
        parameters.Add("idReservation", idReservation);

        using MySqlConnection connection = new(_stringConnection);

        int linhasAfetadas = connection.Execute(query, parameters);

        return linhasAfetadas > 0;
    }

    public bool ConsultarReservas(long idEvent)
    {
        string query = $"SELECT * FROM EventReservation WHERE idEvent = {idEvent}";

        using MySqlConnection connection = new(_stringConnection);

        EventReservation eventReservation = new();

        try
        {
            eventReservation = connection.QueryFirst<EventReservation>(query);
        }
        catch (InvalidOperationException ex)
        {
            connection.Close();
            return false;
        }           
        return true;
    }
}