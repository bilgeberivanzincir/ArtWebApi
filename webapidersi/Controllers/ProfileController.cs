using Microsoft.AspNetCore.Mvc;
using webapidersi.Interfaces;
using webapidersi.Models;
using webapidersi.Repositories;

namespace webapidersi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfileController : Controller
	{

		private readonly  IProfileRepository _profileRepository;
		public ProfileController(IProfileRepository profileRepository) { 
			_profileRepository = profileRepository;
		
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Work>))]
		public IActionResult GetWorks()
		{
			var works = _profileRepository.GetProfiles();
			if (!ModelState.IsValid)

				return BadRequest(ModelState);

			return Ok(works);

		}
		[HttpGet("{ProfileID}")]
		[ProducesResponseType(200, Type = typeof(Work))]
		[ProducesResponseType(400)]
		public IActionResult GetWork(int ID)
		{
			if (!_profileRepository.ProfileExists(ID)) ;
			return NotFound();

			var profile = _profileRepository.GetProfile(ID);

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(profile);

		}
	}
}
