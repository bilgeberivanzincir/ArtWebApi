using Microsoft.AspNetCore.Mvc;
using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Controllers
{
	public class ArtistController : ControllerBase
	{
		private readonly IArtistRepository _artistRepository;

		public ArtistController(IArtistRepository artistRepository)
		{
			_artistRepository = artistRepository;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Artist>))]
		public IActionResult GetArtists()
		{
			var artists = _artistRepository.GetArtists();
			if (!ModelState.IsValid)

				return BadRequest(ModelState);

			return Ok(artists);

		}
		[HttpGet("{artistID}")]
		[ProducesResponseType(200, Type = typeof(Artist))]
		[ProducesResponseType(400)]
		public IActionResult GetArtists(int id)
		{
			if (!_artistRepository.ArtistExists(id));
			return NotFound();

			var artists = _artistRepository.GetArtist(id);

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(artists);

		}

	}
}

