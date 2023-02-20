using API_Eventos.Interfaces;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Consumes("application/json")]
[Produces("application/json")]
[Authorize(Roles = "admin")]
public class EventReservationController : ControllerBase
{
    public List<EventReservation> EventReservationList { get; set; }

    private IEventReservation _eventReservation;

    public EventReservationController(IEventReservation eventReservation)
    {
        _eventReservation = eventReservation;
    }

    [HttpGet("/EventReservation/ConsultarReservas")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "cliente, admin")]
    public ActionResult<List<EventReservation>> ConsultarReservas()
    {
        var eventReservation = _eventReservation.ConsultarReservas();
        if (eventReservation == null)
            return NotFound();
        return Ok(eventReservation);
    }

    [HttpGet("/EventReservation/ConsultarReservaPersonNameETitle")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "cliente, admin")]
    public ActionResult<EventReservation> ConsultarReservaPersonNameETitle(string personName, string title)
    {
        var eventReservation = _eventReservation.ConsultarReservaPersonNameETitle(personName, title);
        if (eventReservation == null)
            return NotFound();
        return Ok(eventReservation);
    }

    [HttpPost("/EventReservation/InserirReserva")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "cliente, admin")]
    public ActionResult<EventReservation> InserirReserva(EventReservation eventReservation)
    {
        if (!_eventReservation.InserirReserva(eventReservation))
        return BadRequest();

        return CreatedAtAction(nameof(InserirReserva), eventReservation);
    }

    [HttpPut("/EventReservation/AtualizarReserva")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "admin")]
    public IActionResult AtualizarReserva(long id, long quantity)
    {
        if (!_eventReservation.AtualizarReserva(id, quantity))
            return NotFound("Reserva não encontrada.");

        return NoContent();
    }

    [HttpDelete("/EventReservation/DeletarReserva")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "admin")]
    public ActionResult<List<EventReservation>> DeletarReserva(long id)
    {
        if (!_eventReservation.DeletarReserva(id))
            return NotFound("Reserva não encontrada.");
        return NoContent();
    }   
}