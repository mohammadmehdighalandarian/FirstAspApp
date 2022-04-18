namespace FirstApp.Models
{
    public class Articles
    {
        public int id { get; set; }
        public string title { get; set; }
        public string Discreption { get; set; }
        public string Image { get; set; }

        public Articles(int id, string title, string discreption, string image)
        {
            this.id = id;
            this.title = title;
            Discreption = discreption;
            Image = image;
        }
    }
}
