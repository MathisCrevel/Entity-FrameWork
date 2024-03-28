using Azure.Identity;

namespace SuperHeros.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public string Power { get; set; }
        public int Id { get; set; }
        public Hero(string name, string power, int id)
        {
            Name = name;
            Power = power;
            Id = id;
        }
        
    }
}
