//using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API_Eventos.Interfaces;

[ApiController]
[Route("[controller]")]
[Consumes("application/json")]
[Produces("application/json")]
[Authorize(Roles = "admin")]
public class CityEventController : ControllerBase
{
    private ICityEvent _cityEvent;

    public CityEventController(ICityEvent cityEvent)
    {
        _cityEvent = cityEvent;
    }

    [HttpGet("/cityEvent/ConsultarEvento")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    public ActionResult<CityEvent> ConsultarEventos()
    {
        var cityEvent = _cityEvent.ConsultarEventos();
        if (cityEvent == null)
        {
            return NotFound();
        }
        return Ok(cityEvent);
    }

    [HttpGet("/cityEvent/ConsultarEventoTitulo")]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    public ActionResult<List<CityEvent>> ConsultarEventoTitulo(string title)
    {
        var cityEventList = _cityEvent.ConsultarEventoTitulo(title);
        if (!cityEventList.Any())
            return NotFound();

        return Ok(cityEventList);
    }

    [HttpGet("/cityEvent/ConsultarEventoDataELocal")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    public ActionResult<List<CityEvent>> ConsultarEventoDataELocal(DateTime dateHourEvent, string local)
    {
        var cityEventList = _cityEvent.ConsultarEventoDataELocal(dateHourEvent, local);
        if (!cityEventList.Any())
            return NotFound();
        return Ok(cityEventList);
    }

    [HttpGet("/cityEvent/ConsultarEventoPrecoEData")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    public ActionResult<List<CityEvent>> ConsultarEventoPrecoEData(decimal low, decimal high, DateTime dateHourEvent)
    {
        var cityEventList = _cityEvent.ConsultarEventoPrecoEData(low, high, dateHourEvent);
        if (!cityEventList.Any())
            return NotFound();
        return Ok(cityEventList);
    }

    [HttpPost("/cityEvent/InserirEvento")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "admin")]
    public ActionResult<CityEvent> InserirEvento(CityEvent cityEvent)
    {
        if (!_cityEvent.InserirEvento(cityEvent))
        {
            return BadRequest();
        }

        return CreatedAtAction(nameof(InserirEvento), cityEvent);
    }

    [HttpPut("/cityEvent/AtualizarEvento")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "admin")]
    public IActionResult AtualizarEvento(CityEvent cityEvent)
    {
        if (!_cityEvent.AtualizarEvento(cityEvent))
        {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }

        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [TypeFilter(typeof(GeneralExceptionFilter))]
    [Authorize(Roles = "admin")]
    public ActionResult<List<CityEvent>> DeletarEvento(long id)
    {
        if (!_cityEvent.DeletarEvento(id))
        {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
        return NoContent();
    }
}