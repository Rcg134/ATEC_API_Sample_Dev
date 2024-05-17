using ATEC_API_Sample.Data.DTO.SocialMediaDTO;

namespace ATEC_API_Sample.Data.IRepository
{
    public interface ISocialMediaRepository
    {
        public Task<List<UserDTO>> GetUserDetails();
    }
}
