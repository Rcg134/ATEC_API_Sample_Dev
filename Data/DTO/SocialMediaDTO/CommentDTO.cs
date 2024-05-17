using ATEC_API_Sample.DomainModels.SocialMedia;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATEC_API_Sample.Data.DTO.SocialMediaDTO
{
    public class CommentDTO
    {
        public string Text { get; set; }
        public DateTime CreatedTime { get; set; }
        public int UserId { get; set; }
    }
}
