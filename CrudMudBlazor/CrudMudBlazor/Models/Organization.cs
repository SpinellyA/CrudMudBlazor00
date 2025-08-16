namespace CrudMudBlazor.Models
{
    public class Organization : Party
    {
        public string OfficialName { get; set; }
        public DateTime FoundingDate { get; set; }
    }
    
}
