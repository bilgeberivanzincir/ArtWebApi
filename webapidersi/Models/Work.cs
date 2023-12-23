namespace webapidersi.Models
{
	public class Work 
	{
        public int ID { get; set; }
        public string Kunye { get; set; }
        public string Aciklama { get; set; }

        public int ExhibitionId { get; set; }
        public Exhibition? Exhibition { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }


    }
}
