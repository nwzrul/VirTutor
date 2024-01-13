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
    public class DiplomasController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public MakesController(ApplicationDbContext context)
        public DiplomasController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Make>>> GetMakes()
        public async Task<IActionResult> GetDiplomas()
        {
            //if (_context.Makes == null)
            //{
            //return NotFound();
            //}
            var diplomas = await _unitOfWork.Diplomas.GetAll();
            return Ok(diplomas);
            //return await _context.Makes.ToListAsync();
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetDiploma(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var diploma = await _unitOfWork.Diplomas.Get(q => q.Id == id);

            if (diploma == null)
            {
                return NotFound();
            }

            //return make;
            return Ok(diploma);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiploma(int id, Diploma diploma)
        {
            if (id != diploma.Id)
            {
                return BadRequest();
            }

            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Diplomas.Update(diploma);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MakeExists(id))
                if (!await DiplomaExists(id))
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
        public async Task<ActionResult<Tutor>> PostDiploma(Diploma diploma)
        {

            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Diplomas.Insert(diploma);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDiploma", new { id = diploma.Id }, diploma);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiploma(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var diploma = await _unitOfWork.Diplomas.Get(q => q.Id == id);

            if (diploma == null)
            {
                return NotFound();
            }

            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Diplomas.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MakeExists(int id)
        private async Task<bool> DiplomaExists(int id)
        {
            //return (_context.Makes?.Any(e => e.Id == id)).GetValueOrDefault();
            var diploma = await _unitOfWork.Diplomas.Get(q => q.Id == id);
            return diploma != null;
        }
    }
}
