namespace FirstApp.Models
{
    public class ItemsInMessageMenue
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ItemsInMessageMenue(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
