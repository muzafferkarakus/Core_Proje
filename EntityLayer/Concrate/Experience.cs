using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrate
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
