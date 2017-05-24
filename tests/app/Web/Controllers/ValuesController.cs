using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private DataContext _dbContext;
        public ValuesController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Value>> Get()
        {
            return await _dbContext.Values.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(long id)
        {
            var val = await _dbContext.Values.FindAsync(id);
            if (val == null)
            {
                return NotFound();
            }

            return Ok(val.Num);
        }

        // POST api/values
        [HttpPost]
        public async Task<StatusCodeResult> Post([FromBody]int value)
        {
            _dbContext.Values.Add(new Value
            {
                Num = value
            });

            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<StatusCodeResult> Put(long id, [FromBody]int value)
        {
            var val = await _dbContext.Values.FindAsync(id);
            if (val == null)
            {
                return NotFound();
            }

            val.Num = value;
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<StatusCodeResult> Delete(long id)
        {
            var val = await _dbContext.Values.FindAsync(id);
            if (val == null)
            {
                return NotFound();
            }

            _dbContext.Values.Remove(val);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
