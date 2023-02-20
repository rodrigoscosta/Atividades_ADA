using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class LogAuthorizationFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        Console.WriteLine("Filtro Autorização");
        context.HttpContext.Request.Headers.TryGetValue("Usuário", out var usuario);
        if (String.IsNullOrEmpty(usuario))
        {
            context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
        }
    }
}