using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Http;

namespace Web.Auth
{
    public class SimpleAuthMiddleware
    {
        public static int inst = 0;
        public const string UserKey = "simpleUser";
        private readonly RequestDelegate _next;

        public SimpleAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, DataContext dbContext)
        {
            string accessToken = httpContext.Request.Headers["Authorization"];
            if (!string.IsNullOrEmpty(accessToken))
            {
                var parts = accessToken.Split(' ');
                if (parts.Length == 2 && parts[0] == "Bearer")
                {
                    accessToken = parts[1];
                    var user = dbContext.Users.SingleOrDefault(u => u.AccessToken == accessToken);
                    if (user != null)
                    {
                        httpContext.Items.Add(UserKey, user);
                    }
                }
            }
            // Call the next middleware delegate in the pipeline 
            await _next.Invoke(httpContext);
        }
    }
}