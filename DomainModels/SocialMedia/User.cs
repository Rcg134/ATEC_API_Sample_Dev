using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATEC_API_Sample.DomainModels.SocialMedia
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }    
        public string Email { get; set; }

        public List<Post> Posts { get; set; }


    }
}
