namespace webapidersi.Models
{
	public class Member
	{
        public int ID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
        public int Password { get; set; }

        public int ProfileId { get; set; }

		public Profile Profile { get; set; }

    }
}
