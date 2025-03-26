using AspNetCore2.Data.Interfaces;
using AspNetCore2.Modles.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2.Controllers;

[Route("api/marks")]
[Controller]

public class MarksController : ControllerBase
{
    private readonly IRepository _repository;
    
    public MarksController(IRepository repository)
    {
        _repository = repository;
    }
    
    // Read

    public async Task<ActionResult<List<MarkDTO>>> GetAllMarks()
    {
        try
        {
            List<MarkDTO> marks = await _repository.GetAllMarksAsync();
            return Ok(marks);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MarkDTO>> GetMarkById(int id)
    {
        try
        {
            MarkDTO mark = await _repository.GetMarkByIdAsync(id);

            if (mark == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mark);
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    // Create

    [HttpPost]
    public async Task<ActionResult> CreateMark([FromBody] MarkDTO mark)
    {
        try
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateMarkAsync(mark);
                return Ok(mark);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    // Update

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateMark(int id, [FromBody] MarkDTO mark)
    {
        try
        {
            var updatedMark = await _repository.UpdateMarkAsync(id, mark);

            if (updatedMark == null)
            {
                return NotFound();
            }

            return Ok(updatedMark);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    
    
    // Delete 

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteMark(int id)
    {
        try
        {
            bool deletedSuccessfully = await _repository.DeleteMarkAsync(id);

            if (!deletedSuccessfully)
            {
                return NotFound(id);
            }
            else
            {
                return NoContent();
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
}