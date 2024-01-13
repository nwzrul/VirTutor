using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutoring.Server.Data;
using OnlineTutoring.Shared.Domain;
using OnlineTutoring.Server.IRepository;

namespace OnlineTutoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostersController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public MakesController(ApplicationDbContext context)
        public PostersController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Make>>> GetMakes()
        public async Task<IActionResult> GetPosters()
        {
            //if (_context.Makes == null)
            //{
            //return NotFound();
            //}
            var posters = await _unitOfWork.Posters.GetAll();
            return Ok(posters);
            //return await _context.Makes.ToListAsync();
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetPoster(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var poster = await _unitOfWork.Posters.Get(q => q.Id == id);

            if (poster == null)
            {
                return NotFound();
            }

            //return make;
            return Ok(poster);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPoster(int id, Poster poster)
        {
            if (id != poster.Id)
            {
                return BadRequest();
            }

            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Posters.Update(poster);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MakeExists(id))
                if (!await PosterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Poster>> PostPoster(Poster poster)
        {

            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Posters.Insert(poster);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPoster", new { id = poster.Id }, poster);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePoster(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var poster = await _unitOfWork.Posters.Get(q => q.Id == id);

            if (poster == null)
            {
                return NotFound();
            }

            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Posters.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MakeExists(int id)
        private async Task<bool> PosterExists(int id)
        {
            //return (_context.Makes?.Any(e => e.Id == id)).GetValueOrDefault();
            var poster = await _unitOfWork.Posters.Get(q => q.Id == id);
            return poster != null;
        }
    }
}
