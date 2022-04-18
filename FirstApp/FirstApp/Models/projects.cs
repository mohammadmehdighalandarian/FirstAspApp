namespace FirstApp.Models
{
    public class projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string image { get; set; }
        public string discreption { get; set; }
        public string Client { get; set; }

        public projects(int id, string name, string image, string discreption, string client)
        {
            Id = id;
            Name = name;
            this.image = image;
            this.discreption = discreption;
            Client = client;
        }
    }
}
