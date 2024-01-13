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
    public class TutorsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public MakesController(ApplicationDbContext context)
        public TutorsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Make>>> GetMakes()
        public async Task<IActionResult> GetTutors()
        {
            //if (_context.Makes == null)
            //{
            //return NotFound();
            //}
            var tutors = await _unitOfWork.Tutors.GetAll();
            return Ok(tutors);
            //return await _context.Makes.ToListAsync();
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetTutor(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var tutor = await _unitOfWork.Tutors.Get(q => q.Id == id);

            if (tutor == null)
            {
                return NotFound();
            }

            //return make;
            return Ok(tutor);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutor(int id, Tutor tutor)
        {
            if (id != tutor.Id)
            {
                return BadRequest();
            }

            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Tutors.Update(tutor);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MakeExists(id))
                if (!await TutorExists(id))
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
        public async Task<ActionResult<Tutor>> PostTutor(Tutor tutor)
        {

            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Tutors.Insert(tutor);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetTutor", new { id = tutor.Id }, tutor);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTutor(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var tutor = await _unitOfWork.Tutors.Get(q => q.Id == id);

            if (tutor == null)
            {
                return NotFound();
            }

            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Tutors.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MakeExists(int id)
        private async Task<bool> TutorExists(int id)
        {
            //return (_context.Makes?.Any(e => e.Id == id)).GetValueOrDefault();
            var tutor = await _unitOfWork.Tutors.Get(q => q.Id == id);
            return tutor != null;
        }
    }
}
