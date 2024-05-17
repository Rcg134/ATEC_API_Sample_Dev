using System.ComponentModel.DataAnnotations;

namespace ATEC_API_Sample.DomainModels.SocialMedia
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;


        // Navigation property
        public User User { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
