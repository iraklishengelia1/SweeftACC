using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EntityFrameworkApp.Models
{
    public class Pupil
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Class { get; set; }
        [JsonIgnore]
        public List<Teacher>Teachers { get; set;}
    }
}
