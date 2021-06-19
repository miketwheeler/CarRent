using CarRent.Server.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRent.Server.Data;
using CarRent.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Get: api/Colors
        // Get: /Colors
        [HttpGet]
        public async Task<IActionResult> GetColors()
        {
            var Colors = await _unitOfWork.Colors.GetAll();
            return Ok(Colors);
        }

        // GET: /Colors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor(int id)
        {
            var Color = await _unitOfWork.Colors.Get(q => q.Id == id);

            if (Color == null)
            {
                return NotFound();
            }

            return Ok(Color);
        }

        // PUT: api/Colors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color color)
        {
            if (id != color.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colors.Update(color);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColorExists(id))
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

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Color>> PostColour(Color color)
        {
            await _unitOfWork.Colors.Insert(color);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColor", new { id = color.Id }, color);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColorExists(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);
            return color == null;
        }
    }
}
