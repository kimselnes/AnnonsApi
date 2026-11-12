using AnnonsApi.Data;
using AnnonsApi.Entities;
using AnnonsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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


        [HttpGet]
        public async Task<ActionResult<List<Ad>>> GetAll()
        {
            return Ok(await _dbContext.Ads.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Ad>> GetAd(int id)
        {
            var ad = await _dbContext.Ads.FindAsync(id);
            if (ad == null)
            {
                return NotFound();
            }
            return Ok(ad);
        }


        [HttpPost]
        public async Task<ActionResult<Ad>> CreateAd(NewAd newAd)
        {
            var ad = new Ad
            {
                Title = newAd.Title,
                Description = newAd.Description,
                Price = newAd.Price
            };

            _dbContext.Ads.Add(ad);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAd), new { id = ad.Id }, ad);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAd(int id)
        {
            var ad = await _dbContext.Ads.FindAsync(id);
            if (ad == null)
            {
                return NotFound();
            }

            _dbContext.Ads.Remove(ad);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<Ad>> UpdateAd(int id, UpdateAd updatedAd)
        {
            var existingAd = await _dbContext.Ads.FindAsync(id);

            if (existingAd == null)
            {
                return NotFound();
            }

            existingAd.Title = updatedAd.Title;
            existingAd.Description = updatedAd.Description;
            existingAd.Price = updatedAd.Price;

            await _dbContext.SaveChangesAsync();

            return Ok(existingAd);
        }

    }
}
