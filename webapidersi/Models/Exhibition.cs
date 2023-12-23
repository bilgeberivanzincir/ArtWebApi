namespace webapidersi.Models
{
	public class Exhibition

	{
        public int ExhibitionId { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }

		public ICollection<Work> Works { get; set; }     //collection navigation property
		public int MuseumId { get; set; }             //bir eser birden fazla müzede sergilenebilir. one-to many
		public Museum Museum { get; set;}

	}
}

//	 public int ArtistId { get; set; }

//	

//public Artist Artist { get; set; }

// public ICollection<Museum> Museums { get; set;}