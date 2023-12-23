namespace webapidersi.Models
{
	public class Museum
	{
        public int ID { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string Address { get; set; }

		public ICollection<Exhibition> Exhibitions { get; set; } //exhibitions of museum
    }
}
