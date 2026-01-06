using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Behaviors
{
    public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        : IPipelineBehavior<TRequest, TResponse>
        where TRequest : notnull, IRequest<TResponse>
        where TResponse : notnull
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var requestTypeName = typeof(TRequest).Name;
            var responseTypeName = typeof(TResponse).Name;

            logger.LogInformation($"[START] Handle Request={requestTypeName} " +
                                  $"- Response={responseTypeName} " +
                                  $"- RequestData={request}");

            var timer = new Stopwatch();
            timer.Start();

            var response = await next();

            timer.Stop();

            var elapsedSeconds = timer.Elapsed.Seconds;

            if (elapsedSeconds > 3)
            {
                logger.LogWarning($"[PERFORMACE] The request {requestTypeName} took {elapsedSeconds}");
            }

            logger.LogInformation($"[END] Handled {requestTypeName} with {responseTypeName}");

            return response;
        }
    }
}
