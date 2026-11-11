using AnnonsApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnnonsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public AdController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
