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
    public class CreditsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public MakesController(ApplicationDbContext context)
        public CreditsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Make>>> GetMakes()
        public async Task<IActionResult> GetCredits()
        {
            //if (_context.Makes == null)
            //{
            //return NotFound();
            //}
            var credits = await _unitOfWork.Credits.GetAll();
            return Ok(credits);
            //return await _context.Makes.ToListAsync();
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetCreditCard(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var credit = await _unitOfWork.Credits.Get(q => q.Id == id);

            if (credit == null)
            {
                return NotFound();
            }

            //return make;
            return Ok(credit);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreditCard(int id, CreditCard credit)
        {
            if (id != credit.Id)
            {
                return BadRequest();
            }

            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Credits.Update(credit);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MakeExists(id))
                if (!await CreditCardExists(id))
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
        public async Task<ActionResult<CreditCard>> PostCreditCard(CreditCard credit)
        {

            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Credits.Insert(credit);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCredit", new { id = credit.Id }, credit);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCreditCard(int id)
        {

            //var make = await _context.Makes.FindAsync(id);
            var credit = await _unitOfWork.Credits.Get(q => q.Id == id);

            if (credit == null)
            {
                return NotFound();
            }

            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Credits.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MakeExists(int id)
        private async Task<bool> CreditCardExists(int id)
        {
            //return (_context.Makes?.Any(e => e.Id == id)).GetValueOrDefault();
            var credit = await _unitOfWork.Credits.Get(q => q.Id == id);
            return credit != null;
        }
    }
}
