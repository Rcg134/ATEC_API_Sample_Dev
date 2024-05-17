using System.ComponentModel.DataAnnotations;

namespace ATEC_API_Sample.DomainModels.SocialMedia
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;


        //Navigation Properties
        public User User { get; set; }
        public Post Post { get; set; }

    }
}
