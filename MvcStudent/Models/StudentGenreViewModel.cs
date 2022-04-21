using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcStudent.Models
{
    public class StudentGenreViewModel
    {
        public List<student>? students { get; set; }
        public SelectList? Gender { get; set; }
        public string? studentGender { get; set; }
        public string? SearchString { get; set; }
    }
}
