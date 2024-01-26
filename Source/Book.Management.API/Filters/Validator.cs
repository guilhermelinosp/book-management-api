using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Book.Management.API.Filters
{
	public class Validator : IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext context)
		{
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			if (!context.ModelState.IsValid)
			{
				var messages = context.ModelState
					.SelectMany(ms => ms.Value?.Errors!)
					.Select(e => e.ErrorMessage)
					.ToList();

				context.Result = new BadRequestObjectResult(messages);
			}
		}
	}
}