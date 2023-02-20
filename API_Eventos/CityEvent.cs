using System.ComponentModel.DataAnnotations;

public class CityEvent
{
    public long IdEvent { get; set; }

    [Required (ErrorMessage = "É necessário informar o título do evento")]
    public string Title { get; set; }
    
    public string Description { get; set; }

    [Required (ErrorMessage = "É necessário informar a data do evento")]
    public DateTime DateHourEvent { get; set; }

    [Required (ErrorMessage = "É necessário informar o local do evento")]
    public string Local { get; set; }

    public string Address { get; set; }
    public decimal Price { get; set; }
    public bool Status { get; set; } = true;
}