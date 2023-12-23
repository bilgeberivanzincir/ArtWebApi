namespace webapidersi.Models
{
	public class Profile
	{
        public int ProfileId { get; set; }
		public int Fallowers { get; set; }	
		public int Fallowing { get; set; }		
		public string? Favorites { get; set; }
        public string Comment { get; set; }
        public string Visited { get; set; }

		public Member Member { get; set; }

    }
}
