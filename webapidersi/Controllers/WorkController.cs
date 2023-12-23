using Microsoft.AspNetCore.Mvc;
using webapidersi.Interfaces;
using webapidersi.Models;
using webapidersi.Repositories;

namespace webapidersi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WorkController : Controller
	{
		private	readonly IWorkRepository _workRepository;
		public WorkController(IWorkRepository workRepository)
		{
			_workRepository = workRepository;
		
		}
		[HttpGet]
		[ProducesResponseType(200,Type = typeof(IEnumerable<Work>))]
		public IActionResult GetWorks()
		{
			var works=_workRepository.GetWorks();
			if(!ModelState.IsValid)
			
				return BadRequest(ModelState);
			
			return Ok(works);

		}
		[HttpGet("{WorkID}")]
		[ProducesResponseType(200, Type = typeof(Work))]
		[ProducesResponseType(400)]
		public IActionResult GetWork(int ID)
		{
			if (!_workRepository.WorksExists(ID));
			return NotFound();

			var work = _workRepository.GetWork(ID);

			if(!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(work);

		}

	}
}
