using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using webapidersi.Interfaces;
using webapidersi.Models;
using webapidersi.Repositories;

namespace webapidersi.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class ExhibitionController: ControllerBase
	{
		private readonly IExhibitionRepository _exhibitionRepository;

		public ExhibitionController(IExhibitionRepository exhibitionRepository)
		{
			_exhibitionRepository = exhibitionRepository;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Exhibition>))]
		public IActionResult GetExhibitions()
		{
			var exhibitions = _exhibitionRepository.GetExhibitions();
			if (!ModelState.IsValid)

				return BadRequest(ModelState);

			return Ok(exhibitions);

		}
		[HttpGet("{ID}")]
		[ProducesResponseType(200, Type = typeof(Exhibition))]
		[ProducesResponseType(400)]
		public IActionResult GetExhibitions(int id)
		{
			if (!_exhibitionRepository.ExhibitionExists(id)) ;
			return NotFound();

			var exhibitions= _exhibitionRepository.GetExhibition(id);

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(exhibitions);

		}
		[HttpPost]
		public IActionResult CreateExhibition([FromBody] Exhibition exhibition)
		{
			
				if (exhibition == null)
					return BadRequest(); //400

				_exhibitionRepository.CreateExhibition(exhibition);
			if(!_exhibitionRepository.Save())
			{
				throw new Exception("Bir sergi yaratma hatası oluştu.");

			}
			return CreatedAtAction("GetExhibitions", new { id = exhibition.ExhibitionId }, exhibition);   //http 201 created

		}

		[HttpPut]
		public IActionResult UpdateExhibition(int id, [FromBody] Exhibition exhibition)
		{
			if (exhibition == null || id != exhibition.ExhibitionId)
			{
				return BadRequest();
			}
			if (!_exhibitionRepository.ExhibitionExists(id) )
				return NotFound();

			_exhibitionRepository.UpdateExhibition(exhibition);
			if (!_exhibitionRepository.Save())
			{
				throw new Exception($"Updating member {id} failed on save.");
			}

			return NoContent(); //204, içerik güncellendi 
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteExhibition(int id)
		{
			try
			{
				var exh = _exhibitionRepository.GetExhibition(id);
				if (exh == null)
				{
					return NotFound();
				}

				_exhibitionRepository.DeleteExhibition(id);

				if (_exhibitionRepository.Save())
				{ 
					throw new Exception($"Sergi silinirken veritabanı kaydetme hatası oluştu. Hata Ayrıntıları:");
				
			}

				return NoContent(); 
			}
			catch (Exception ex)
			{
			    // Logger.LogError(ex, "Sergi silinirken bir hata oluştu.");

				return BadRequest("Sergi silinirken bir hata oluştu. Detaylar için sunucu loglarına bakınız.");
			}
		}

		
	}

}
