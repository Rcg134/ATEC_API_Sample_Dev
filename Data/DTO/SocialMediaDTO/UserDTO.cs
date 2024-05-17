using ATEC_API_Sample.DomainModels.SocialMedia;

namespace ATEC_API_Sample.Data.DTO.SocialMediaDTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public List<PostDTO> Posts { get; set; }

    }
}
