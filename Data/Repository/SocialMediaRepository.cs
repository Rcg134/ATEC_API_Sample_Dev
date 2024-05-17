using ATEC_API_Sample.Data.Context;
using ATEC_API_Sample.Data.DTO.SocialMediaDTO;
using ATEC_API_Sample.Data.IRepository;
using ATEC_API_Sample.DomainModels.SocialMedia;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ATEC_API_Sample.Data.Repository
{
    public class SocialMediaRepository : ISocialMediaRepository
    {
        private readonly SocialMediaContext _socialMediaContext;
        private readonly IMapper _mapper;

        public SocialMediaRepository(SocialMediaContext socialMediaContext,
                                     IMapper mapper)
        {
            _socialMediaContext = socialMediaContext;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetUserDetails()
        {
            var userDetails = await _socialMediaContext
                           .Users
                           .Include(u => u.Posts)
                               .ThenInclude(p => p.Comments)
                                 .ThenInclude(u => u.User)
                           .AsNoTracking()
                           .ToListAsync();


            if (userDetails == null)
            {
                return null;
            }

            return _mapper.Map<List<UserDTO>>(userDetails);

        }
    }
}
