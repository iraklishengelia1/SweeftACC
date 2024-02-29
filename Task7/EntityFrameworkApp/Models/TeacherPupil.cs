using Azure;
using Microsoft.Extensions.Hosting;

namespace EntityFrameworkApp.Models
{
    public class TeacherPupil
    {
        public int TeacherId { get; set; }
        public int PupilId { get; set; }
        public Teacher Teacher { get; set; } = null!;
        public Pupil Pupil { get; set; } = null!;
    }
}
