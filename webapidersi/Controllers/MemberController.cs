using Microsoft.AspNetCore.Mvc;
using webapidersi.Interfaces;
using webapidersi.Models;
using webapidersi.Repositories;

namespace webapidersi.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class MemberController : ControllerBase
	{
		private readonly IMemberRepository _memberRepository;

		public MemberController(IMemberRepository memberRepository)
		{
			_memberRepository = memberRepository;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Member>))]
		public IActionResult GetMembers()
		{
			var members = _memberRepository.GetMembers();
			if (!ModelState.IsValid)

				return BadRequest(ModelState);

			return Ok(members);

		}

		[HttpGet("{memberID}")]
		[ProducesResponseType(200, Type = typeof(Member))]
		[ProducesResponseType(400)]
		public IActionResult GetMember(int id)
		{
			if (!_memberRepository.MemberExists(id)) ;
			return NotFound();

			var members = _memberRepository.GetMember(id);

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(members);

		}

		[HttpPost]
		public IActionResult CreateMember([FromBody] Member member)
		{

			if (member == null)
				return BadRequest(); //400

			_memberRepository.CreateMember(member);
			if (!_memberRepository.Save())
			{
				throw new Exception("Bir sergi yaratma hatası oluştu.");

			}
			return CreatedAtAction("GetMembers", new { id = member.ID }, member);   //http 201 created

		}

		[HttpPut]
		public IActionResult UpdateMember(int id, [FromBody] Member member)
		{
			if (member == null || id != member.ID)
			{
				return BadRequest();
			}
			if (!_memberRepository.MemberExists(id))
				return NotFound();

			_memberRepository.UpdateMember(member);
			if (!_memberRepository.Save())
			{
				throw new Exception($"Updating member {id} failed on save.");
			}

			return NoContent(); //204, içerik güncellendi 
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteMember(int id)
		{
			var member = _memberRepository.GetMember(id);
			if (member == null)
			{
				return NotFound();
			}
			_memberRepository.DeleteMember(id);
			if (_memberRepository.Save())
			{
				throw new Exception($"Üye silinirken hata oluştu.");

			}
			return NoContent();
		}
	}
}