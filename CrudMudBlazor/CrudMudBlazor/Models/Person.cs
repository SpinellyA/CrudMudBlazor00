namespace CrudMudBlazor.Models
{
    public class Person : Party
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
    
}
