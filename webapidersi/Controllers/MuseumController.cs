using Microsoft.AspNetCore.Mvc;
using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MuseumController : ControllerBase
	{
		
		private readonly IMuseumRepository _museumRepository;

		public MuseumController(IMuseumRepository museumRepository)
		{
			_museumRepository = museumRepository;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Exhibition>))]
		public IActionResult GetMuseums()
		{
			var museums = _museumRepository.GetMuseums();
			if (!ModelState.IsValid)

				return BadRequest(ModelState);

			return Ok(museums);

		}
		[HttpGet("{museumID}")]
		[ProducesResponseType(200, Type = typeof(Museum))]
		[ProducesResponseType(400)]
		public IActionResult GetMuseums(int id)
		{
			if (!_museumRepository.MuseumExists(id)) ;
			return NotFound();

			var museum = _museumRepository.GetMuseum(id);

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(museum);

		}

	}
}
	

