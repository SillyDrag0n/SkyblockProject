namespace SkyblockProject.Models
{
    public class Collection
    {
        //ID => Primary Key
        public int Id { get; set; }
        public string? CollectionTitle { get; set; }
        //fk_CollectionGroup points to Table CollectionGroup, Field ID
        public string? fk_CollectionGroup { get; set; }
        //Level shows the Collection Levels
        public int Level { get; set; }
        //Experience shows the needed Experience needed for the Level
        public int Experience { get; set; }
    }
}
