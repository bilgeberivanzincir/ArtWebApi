using Microsoft.EntityFrameworkCore.Query.Internal;
using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Repositories
{
	public class WorkRepository : IWorkRepository
	{
		private readonly RepositoryContext _context;
		public WorkRepository(RepositoryContext context)
		{
			_context = context;
		
		}

		public Work GetWork(int id)
		{
			return _context.Works.Where(p => p.ID == id).FirstOrDefault();
		}

		public Work GetWork(string name)
		{
			return _context.Works.Where(p => p.Kunye == name).FirstOrDefault();
		}

		public ICollection<Work> GetWorks()
		{
			return _context.Works.OrderBy(p => p.ID).ToList();

		}

		public bool WorksExists(int ıD)
		{
			throw new NotImplementedException();
		}
	}
}
