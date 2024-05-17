namespace ATEC_API_Sample.Data.DTO.SocialMediaDTO
{
    public class PostDTO
    {

            public string Title { get; set; }
            public string Description { get; set; }
            public List<CommentDTO> Comments { get; set; }
    
    }
}
