using AspNetCore2.Data.Interfaces;
using AspNetCore2.Modles;
using AspNetCore2.Modles.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2.Controllers;

[Route("api/teachers")]
[Controller]

public class TeachersController : ControllerBase
{
    private readonly IRepository _repository;
    
    public TeachersController(IRepository repository)
    {
        _repository = repository;
    }
    
    
    // Read
    
    [HttpGet]
    public async Task<ActionResult<List<TeacherDTO>>> GetAllTeachers()
    {
        try
        {
            List<TeacherDTO> teachers = await _repository.GetAllTeachersAsync();
            return Ok(teachers);

        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<TeacherDTO>> GetTeachersById(int id)
    {
        try
        {
            TeacherDTO teacher = await _repository.GetTeacherByIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(teacher);
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    // Create
    
    [HttpPost]
    public async Task<IActionResult> CreateTeacher([FromBody] Teacher teacher)
    {
        try
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateTeacherAsync(teacher);
                return CreatedAtAction(nameof(GetTeachersById), new { id = teacher.TeacherId }, teacher);
            }
            else
            {
                return BadRequest();
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    // Update
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTeacher(int id, [FromBody] Teacher teacher)
    {
        try
        {
            Teacher teach = await _repository.UpdateTeacherAsync(id, teacher);
           if (teach == null)
           {
               return NotFound();
           }
           else
           {
               return CreatedAtAction(nameof(GetTeachersById), new { id = teach.TeacherId }, teach);
           }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    // Delete
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<Teacher>> DeleteTeacher(int id)
    {
        try
        {
            bool deleteSuccessfull = await _repository.DeleteTeacherAsync(id);
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