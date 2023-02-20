using Dapper;
using MySqlConnector;
using API_Eventos.Interfaces;
using Microsoft.Extensions.Configuration;

public class CityEventRepository : ICityEventRepository
{
    private string _stringConnection = Environment.GetEnvironmentVariable("DATABASE_CONFIG");

    public CityEventRepository()
    {  
    }

    public List<CityEvent> ConsultarEventos()
    {
        string query = "SELECT * FROM CityEvent";

        //O using nessa string é responsável por encerrar a conexão com o BD
        using MySqlConnection connection = new(_stringConnection);

        return connection.Query<CityEvent>(query).ToList();
    }

    public List<CityEvent> ConsultarEventoTitulo(string title)
    {
        string query = "SELECT * FROM CityEvent WHERE Title LIKE ('%' +  @title + '%') ";
        DynamicParameters parameters = new(new
        {
            title
        });

            
        using MySqlConnection connection = new(_stringConnection);
        return connection.Query<CityEvent>(query, parameters).ToList();     
    }

    public List<CityEvent> ConsultarEventoDataELocal(DateTime dateHourEvent, string local)
    {
        string query = $"SELECT * FROM CityEvent WHERE CONVERT(DATE, DateHourEvent)= @dateHourEvent AND Local Like('%' +  @local + '%') ";
        DynamicParameters parameters = new(new
        {
            dateHourEvent,
            local
        });

        using MySqlConnection connection = new(_stringConnection);
        return connection.Query<CityEvent>(query, parameters).ToList(); 
    }

    public List<CityEvent> ConsultarEventoPrecoEData(decimal low, decimal high, DateTime dateHourEvent)
    {
        string query = $"SELECT * FROM CityEvent WHERE Price >= @low AND Price <= @high AND CONVERT(DATE, DateHourEvent)= @dateHourEvent";
        DynamicParameters parameters = new(new
        {
            low,
            high,
            dateHourEvent
        });

        using MySqlConnection connection = new(_stringConnection);
        return connection.Query<CityEvent>(query, parameters).ToList();
    }

    public bool InserirEvento(CityEvent cityEvent)
    {
        string query = "INSERT INTO CityEvent (idEvent, title, description, dateHourEvent, local, address, price, status)" + 
                        "VALUES (@idEvent, @title, @description, @dateHourEvent, @local, @address, @price, @status)";
        
        DynamicParameters parameters = new();
        parameters.Add("idEvent", cityEvent.IdEvent);
        parameters.Add("title", cityEvent.Title);
        parameters.Add("description", cityEvent.Description);
        parameters.Add("dateHourEvent", cityEvent.DateHourEvent);
        parameters.Add("local", cityEvent.Local);
        parameters.Add("address", cityEvent.Address);
        parameters.Add("price", cityEvent.Price);
        parameters.Add("status", cityEvent.Status);

        using MySqlConnection connection = new(_stringConnection);

        return connection.Execute(query, parameters) == 1;
    }

    public bool AtualizarEvento(CityEvent cityEvent)
    {
        string query = @"UPDATE CityEvent set Title = @title, Description = @description,
                            DateHourEvent = @dateHourEvent, Local = @local, Address = @address,
                            Price = @price, Status = @status
                            where IdEvent = @idEvent";

        DynamicParameters parameters = new(cityEvent);

        using MySqlConnection connection = new(_stringConnection);

        return connection.Execute(query, parameters) == 1;  
    }

    public bool DeletarEvento(long idEvent)
    {
        var query = "DELETE FROM CityEvent WHERE IdEvent = @idEvent";

        DynamicParameters parameters = new(new
        {
            idEvent
        });

        using MySqlConnection connection = new(_stringConnection);

        return connection.Execute(query, parameters) == 1;      
    }
}

public interface ICityEventRepository
{
}