using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace vosplzen.sem2._2023k.Filters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TokenAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = context.HttpContext.Request.Headers["Security-Token"];
            if (string.IsNullOrEmpty(token) || !token.Equals("dm9zUGx6ZW4zNW5hYWRyZXNlTGVkZWNrYQ=="))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

        }
    }
}
