namespace SkyblockProject.Models
{
    public class Collection
    {
        //ID => Primary Key
        public int Id { get; set; }
        //Fk_CollectionGroup is for filtering the Collections
        public int Fk_CollectionGroup { get; set; }
        //collectionTitel contains the title of the collection
        public string? CollectionTitle { get; set; }
        //collectionLevel shows the Collection Levels
        public int CollectionLevel { get; set; }
        //collectionNeededExp shows the needed Experience needed for the Level
        public int CollectionNeededExp { get; set; }
        //collectionUnlock shows what you unlock with the Level
        public string? CollectionUnlock { get; set; }
    }
}
