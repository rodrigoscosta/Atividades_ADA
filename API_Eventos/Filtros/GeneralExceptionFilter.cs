using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MySqlConnector;

public class GeneralExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var problem = new ProblemDetails
        {
            Title = "Erro inesperado",
            Detail = "Ocorreu um erro inesperado na solicitação",
            Type = context.Exception.GetType().Name
        };

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(problem);

        switch (context.Exception)
        {
            case MySqlException:
                problem.Title = "Erro de conexão";
                problem.Detail = "Erro de conexão com o banco de dados";
                context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Result = new ObjectResult(problem);
                break;
                
            default:
                context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Result = new ObjectResult(problem);
                break;
        }

    }
}