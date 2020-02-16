namespace Demo.Database.Entities.Identity
{
    public class Base
    {
        public int InstitutionId { get; set; }
        public string Code { get; set; }
        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }
        public string Name { get; set; }
    }
}
