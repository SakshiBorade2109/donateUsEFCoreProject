using DonateUsEfCore2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DonateUsEfCore2.Controllers
{
    [Route("api/languages")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDBContext _dbContext;
        public LanguageController(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }

        [HttpGet("/allLanguages")]
        public IActionResult GetAllLanguages()
        {
            //var result = _dbContext.Languages.ToList();
            var result = from LanguageLocalization in _dbContext.Languages select LanguageLocalization;
            return Ok(result);
        }

        /* [HttpGet("/language")]
         public async Task<IActionResult> getLanguageByLanguageId(int languageId)
         {
             var result = await (_dbContext.Languages.Where(d=>d.id==languageId).ToListAsync());
             return Ok(result);
         }*/

        [HttpGet("{id:int}")]
        public async Task<IActionResult> getLanguageByLanguageId([FromRoute] int id)
        {
            var result = await (_dbContext.Languages.Where(d => d.id == id).ToListAsync());
            if(result.Count>0)
            return Ok(result);

            else
                return BadRequest();
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> getLanguageByLanguageName([FromRoute] string name)
        {
            var result = await (_dbContext.Languages.Where(d => d.language.Equals(name)).ToListAsync());
            if (result.Count > 0)
                return Ok(result);

            else
                return BadRequest();
        }

        [HttpGet("double/{id}")]
        public async Task<IActionResult> getLanguageByLanguageName([FromQuery] string? name, [FromRoute] int id)
        {
            var result = await (_dbContext.Languages.Where(d => (string.IsNullOrEmpty(name)|| d.language.Equals(name)) && d.id==id).SingleOrDefaultAsync());
            if (result != null)
                return Ok(result);

            else
                return BadRequest();
        }
    }
}
