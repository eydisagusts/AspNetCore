using AspNetCore2.Data.Interfaces;
using AspNetCore2.Modles.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2.Controllers;

[Route("api/subjectteacher")]
[Controller]

public class SubjectTeachersController : ControllerBase
{
    private readonly IRepository _repository;

    public SubjectTeachersController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<SubjectTeacherDTO>>> GetAllSubjectTeachers()
    {

        try
        {
            List<SubjectTeacherDTO> subjteacher = await _repository.GetAllSubjectTeachersAsync();
            
            return Ok(subjteacher);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<SubjectTeacherDTO>> GetSubjectTeacherById(int id)
    {
        
        try
        {
            SubjectTeacherDTO subteach = await _repository.GetSubjectTeacherByIdAsync(id);
            if (subteach == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(subteach);
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
}
    
    
