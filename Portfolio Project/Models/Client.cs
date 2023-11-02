namespace Portfolio_Project.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }

        public Client(int id, string name, string website)
        {
            Id = id;
            Name = name;
            Website = website;
        }

    }
}
