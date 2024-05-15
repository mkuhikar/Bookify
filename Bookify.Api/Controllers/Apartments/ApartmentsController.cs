using Bookify.Application.Apartments.SearchApartments;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Api.Controllers.Apartments
{
	//API controller tell .Net runtime that this is a API controller. It is more
	//lightweight  and requires less services, and little more
	//performant than the MVC controller
	[ApiController]
	[Route("api/apartments")]
	public class ApartmentsController : ControllerBase
	{
		private readonly ISender _sender;

		public ApartmentsController(ISender sender)
		{
			_sender = sender;
		}

		[HttpGet]
		public async Task<IActionResult> SearchApartments(
			DateOnly startDate,
			DateOnly endDate,
			CancellationToken cancellationToken)
		{
			var query = new SearchApartmentsQuery(startDate, endDate);
			var result = await _sender.Send(query, cancellationToken);
			return Ok(result.Value);
		}
			
	}
}
