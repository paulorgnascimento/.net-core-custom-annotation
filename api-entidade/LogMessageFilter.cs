using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace api_entidade
{
    public class LogMessageFilter : IActionFilter
    {
        private readonly ILogger<LogMessageFilter> _logger;

        public LogMessageFilter(ILogger<LogMessageFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var method = context.ActionDescriptor as ControllerActionDescriptor;
            if (method != null)
            {
                var attributes = method.MethodInfo.GetCustomAttributes(typeof(LogMessageAttribute), false);
                if (attributes.Any())
                {
                    var logAttribute = attributes.First() as LogMessageAttribute;
                    _logger.LogInformation(logAttribute.Message);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
