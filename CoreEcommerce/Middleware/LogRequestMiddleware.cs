using CoreEcommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CoreEcommerce.Middleware
{
    public class LogRequestMiddleware
    {
        private ApplicationContext dbcontext;

        public LogRequestMiddleware(ApplicationContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        private readonly RequestDelegate next;
        //private readonly ILogger _logger;
        //private Func<state, System.Exception, string> _defaultFormatter = (state, exception) => state;

        public LogRequestMiddleware(RequestDelegate next, ApplicationContext dbcontext)
        {
            this.next = next;
            //_logger = logger;
            this.dbcontext = dbcontext;
        }

        public async Task Invoke(HttpContext context)
        {
            var requestBodyStream = new MemoryStream();
            var originalRequestBody = context.Request.Body;

            await context.Request.Body.CopyToAsync(requestBodyStream);
            requestBodyStream.Seek(0, SeekOrigin.Begin);

            var url = UriHelper.GetDisplayUrl(context.Request);
            var requestBodyText = new StreamReader(requestBodyStream).ReadToEnd();

            // Create new Request Model
            LogRequest r = new LogRequest();
            r.method = context.Request.Method;
            r.body = requestBodyText;
            r.url = url;
            r.created = DateTime.UtcNow;

            dbcontext.Requests.Add(r);
            dbcontext.SaveChanges();

            //_logger.Log(LogLevel.Information, 1, $"REQUEST METHOD: {context.Request.Method}, REQUEST BODY: {requestBodyText}, REQUEST URL: {url}", null);

            requestBodyStream.Seek(0, SeekOrigin.Begin);
            context.Request.Body = requestBodyStream;

            await next(context);
            context.Request.Body = originalRequestBody;
        }
    }
}
