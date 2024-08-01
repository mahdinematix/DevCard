namespace DevCard_MVC.Models
{
	public class Article
	{
		public long Id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }
		public string Image { get; set; }

		public Article(long id, string name, string desc, string image)
		{
			Id = id;
			this.name = name;
			this.desc = desc;
			Image = image;
		}
	}
}
