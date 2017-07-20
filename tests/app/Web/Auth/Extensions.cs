using Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
namespace Web.Auth
{

    public static class Extensions
    {
        public static IApplicationBuilder UseSimpleAuth(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SimpleAuthMiddleware>();
        }
        public static User GetUser(this HttpContext context)
        {
            return context.Items[SimpleAuthMiddleware.UserKey] as User;
        }
    }
}