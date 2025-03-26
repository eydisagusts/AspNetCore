using AspNetCore2.Data.Interfaces;
using AspNetCore2.Modles;
using AspNetCore2.Modles.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2.Controllers;

[Route("api/students")]
[Controller]

public class StudentsController : ControllerBase
{
    private readonly IRepository _repository;
    
    public StudentsController(IRepository repository)
    {
        _repository = repository;
    }
    
    // Read

    [HttpGet]
    public async Task<ActionResult<List<StudentReadDTO>>> GetAllStudents()
    {
        try
        {
            List<StudentReadDTO> students = await _repository.GetAllStudentsAsync();
            return Ok(students);

        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    

    [HttpGet("{id}")]
    public async Task<ActionResult<StudentDetailsDTO>> GetStudentById(int id)
    {
        try
        {
            StudentDetailsDTO stud = await _repository.GetStudentByIdAsync(id);
            if (stud == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(stud);
            }
        }
        catch (Exception)
        {
            StatusCode(500);
        }
        return NotFound();
    }
    
    // Create
    [HttpPost]
    public async Task<IActionResult> CreateStudent([FromBody]StudentCreateDTO dto)
    {
        try
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateStudentAsync(dto);
                return Ok(dto);
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
    public async Task<IActionResult> UpdateStudent(int id, [FromBody] StudentCreateDTO dto)
    {
        try
        {
            StudentReadDTO student = await _repository.UpdateStudentAsync(id, dto);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        try
        {
            bool deleteSuccessfull = await _repository.DeleteStudentAsync(id);

            if (!deleteSuccessfull)
            {
                return NotFound();
            }
            else
            {
                return NoContent();
            }
        } catch (Exception)

        {
            return StatusCode(500);
        }
    }
}

