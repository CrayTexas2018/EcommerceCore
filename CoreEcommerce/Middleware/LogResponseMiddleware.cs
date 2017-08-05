using CoreEcommerce.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Middleware
{
    public class LogResponseMiddleware
    {
        private ApplicationContext dbcontext;        

        private readonly RequestDelegate _next;

        public LogResponseMiddleware(RequestDelegate next, ApplicationContext dbcontext)
        {
            _next = next;
            this.dbcontext = dbcontext;
        }

        public async Task Invoke(HttpContext context)
        {            
            var bodyStream = context.Response.Body;

            var responseBodyStream = new MemoryStream();
            context.Response.Body = responseBodyStream;

            await _next(context);

            responseBodyStream.Seek(0, SeekOrigin.Begin);
            var responseBody = new StreamReader(responseBodyStream).ReadToEnd();
            // Save to database
            LogResponse r = new LogResponse();
            r.body = responseBody;
            r.created = DateTime.UtcNow;
            dbcontext.Add(r);
            dbcontext.SaveChanges();

            responseBodyStream.Seek(0, SeekOrigin.Begin);
            await responseBodyStream.CopyToAsync(bodyStream);
        }
    }
}
