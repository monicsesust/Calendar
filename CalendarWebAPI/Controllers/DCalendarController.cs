using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CalendarWebAPI.Models;

namespace CalendarWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DCalendarController : ControllerBase
    {
        private readonly CalendarDBContext _context;

        public DCalendarController(CalendarDBContext context)
        {
            _context = context;
        }

        // GET: api/DCalendar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DCalendar>>> GetDCalendars()
        {
            return await _context.DCalendars.ToListAsync();
        }

        // GET: api/DCalendar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DCalendar>> GetDCalendar(int id)
        {
            var dCalendar = await _context.DCalendars.FindAsync(id);

            if (dCalendar == null)
            {
                return NotFound();
            }

            return dCalendar;
        }

        // PUT: api/DCalendar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDCalendar(int id, DCalendar dCalendar)
        {
            dCalendar.id = id;

            _context.Entry(dCalendar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DCalendarExists(id))
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

        // POST: api/DCalendar
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DCalendar>> PostDCalendar(DCalendar dCalendar)
        {
            _context.DCalendars.Add(dCalendar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDCalendar", new { id = dCalendar.id }, dCalendar);
        }

        // DELETE: api/DCalendar/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DCalendar>> DeleteDCalendar(int id)
        {
            var dCalendar = await _context.DCalendars.FindAsync(id);
            if (dCalendar == null)
            {
                return NotFound();
            }

            _context.DCalendars.Remove(dCalendar);
            await _context.SaveChangesAsync();

            return dCalendar;
        }

        private bool DCalendarExists(int id)
        {
            return _context.DCalendars.Any(e => e.id == id);
        }
    }
}
