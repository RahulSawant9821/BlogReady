using System.ComponentModel.DataAnnotations;

namespace BlogReady.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        [Required]  
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }


    }
}
