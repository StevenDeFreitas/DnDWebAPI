namespace DnDWebAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Ladle";
        public int Level { get; set; } = 1;
        public string Class { get; set; } = "Bard";
        public string[] Weapons { get; set; } = new string[] { "Bagpipes", "Soup Ladle" };
    }
}
