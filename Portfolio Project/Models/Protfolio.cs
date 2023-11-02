using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Models
{
    public class Protfolio
    {
        int MAX_NAME_LENGHT = 100;
        


        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }


        public Protfolio(int id, string name, string image, string description)
        {
            ValidateName(name);

            Id = id;
            Name = name;
            Image = image;
            Description = description;
        }


        public void ValidateName(string name)
        {
            if (name.Length > MAX_NAME_LENGHT)
            {
                throw new Exception("Name characters are more than 100");
            }
        }
    }
}
