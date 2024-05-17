using ATEC_API_Sample.Data.IRepository;
using ATEC_API_Sample.GeneralModel;
using Microsoft.AspNetCore.Mvc;

namespace ATEC_API_Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaRepository _socialMediaRepository;

        public SocialMediaController(ISocialMediaRepository socialMediaRepository)
        {
            _socialMediaRepository = socialMediaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
          var userDetails = await _socialMediaRepository.GetUserDetails();

          return Ok(new GeneralResponse {
                                        Details = userDetails
                                        });

        }

    }
}
