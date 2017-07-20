using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web.Auth {
    public class AuthAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var user = context.HttpContext.GetUser();
            if (user == null)
            {
                context.Result = new UnauthorizedResult();
            }
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
        }
    }
}