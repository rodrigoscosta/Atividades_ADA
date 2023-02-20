using System.ComponentModel.DataAnnotations;

public class EventReservation
{
    public long IdReservation { get; set; }
        
    [Required (ErrorMessage = "O ID do evento precisa ser informado")]
    public long IdEvent { get; set; }

    [Required (ErrorMessage ="É necessário informar o nome da pessoa que fez a reserva")]
    public string PersonName { get; set; }

    [Required (ErrorMessage = "É necessário informar a quantidade de ingressos")]
    public long Quantity { get; set; }
}