using AspNetCore2.Data.Interfaces;
using AspNetCore2.Modles;
using AspNetCore2.Modles.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2.Controllers;

[Route("api/subjects")]
[Controller]

public class SubjectsController : ControllerBase
{
    private readonly IRepository _repository;
    
    public SubjectsController(IRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Subject>>> GetAllSubjects()
    {
        try
        {
            List<SubjectReadDTO> subjects = await _repository.GetAllSubjectsAsync();
            return Ok(subjects);

        } catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SubjectDetailsDTO>> GetSubjectById(int id)
    {
        try
        {
            SubjectDetailsDTO subject = await _repository.GetSubjectByIdAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(subject);
            }
            
        } catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    
    // Create


    [HttpPost]
    public async Task<ActionResult> CreateSubject([FromBody] SubjectCreateDTO subject)
    {
        try
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateSubjectAsync(subject);
                return Ok(subject);
            }
            else
            {
                return BadRequest(ModelState);
            }
            
        } catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    // Update

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateSubject(int id, [FromBody] SubjectUpdateDTO subject)
    {
        try
        {
            SubjectReadDTO sub = await _repository.UpdateSubjectAsync(id, subject);
            if (sub == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(subject);
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    // Delete
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteSubject(int id)
    {
        try
        {
            bool deleteSuccessfull = await _repository.DeleteSubjectAsync(id);
            if (!deleteSuccessfull)
            {
                return NotFound();
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