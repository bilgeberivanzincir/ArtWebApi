using webapidersi.Models;

namespace webapidersi.Interfaces
{
	public interface IExhibitionRepository
	{

		ICollection<Exhibition> GetExhibitions();

		Exhibition GetExhibition(int id);

		bool ExhibitionExists(int id);

		void CreateExhibition(Exhibition exhibition);
		void UpdateExhibition(Exhibition exhibition);
		void DeleteExhibition(int id);

		bool Save();
	
	}
}
