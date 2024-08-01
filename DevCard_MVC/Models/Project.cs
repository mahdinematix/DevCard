namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Client { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string Image { get; set; }

        public Project(long id, string client, string desc, string image,string name )
        {
            Id = id;
            Client = client;
            this.name = name;
            
            Image = image;
            this.desc = desc;
		}
    }
}
