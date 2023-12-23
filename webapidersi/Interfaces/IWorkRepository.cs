using webapidersi.Models;

namespace webapidersi.Interfaces
{
	public interface IWorkRepository
	{
		ICollection<Work> GetWorks();
		Work GetWork(int id);
		Work GetWork(String name);
		bool WorksExists(int ıD);
	}
}
