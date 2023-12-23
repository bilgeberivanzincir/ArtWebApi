using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Repositories
{
	public class ExhibitionRepository : IExhibitionRepository
	{
		private RepositoryContext _context;

		private readonly ILoggerService _logger;

		public ExhibitionRepository(RepositoryContext context, ILoggerService logger)
		{

			_context = context;
			_logger = logger;

		}
		public Exhibition GetExhibition(int id)
		{
			return _context.Exhibitions.FirstOrDefault(e => e.ExhibitionId == id);
		}


		public void CreateExhibition(Exhibition exhibition)
		{
			_context.Exhibitions.Add(exhibition);
		}
		public void UpdateExhibition(Exhibition exhibition)
		{
			_context.Exhibitions.Update(exhibition);

		}
		public void DeleteExhibition(int id)
		{
			var exhibition = GetExhibition(id);
			if (exhibition is null)
			{
				_logger.LogInfo($"the book with id:{id} could not found.");
				throw new Exception($"the book with id:{id} could not found.");
			}
			_context.Exhibitions.Remove(exhibition);
			_context.SaveChanges(); //?????

		}
		public bool ExhibitionExists(int id)
		{
			return _context.Exhibitions.Any(e=> e.ExhibitionId == id);
		}


		public ICollection<Exhibition> GetExhibitions()
		{
			return _context.Exhibitions.ToList();
		}

		public bool Save()
		{
			var saved= _context.SaveChanges();
			return saved>0 ? true : false;
		}


	}
}
