using AspNetCore2.Data.Interfaces;
using AspNetCore2.Modles.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2.Controllers;

[Route("api/groups")]
[Controller]

public class GroupsController : ControllerBase
{

    private readonly IRepository _repository;
    
    public GroupsController(IRepository repository)
    {
        _repository = repository;
    }
    
    // Read

    [HttpGet]
    public async Task<ActionResult<List<GroupDTO>>> GetAllGroups()
    {
        try
        {
            List<GroupDTO> groups = await _repository.GetAllGroupsAsync();
            return Ok(groups);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GroupDetailsDTO>> GetGroupById(int id)
    {
        try
        {
            GroupDetailsDTO group = await _repository.GetGroupByIdAsync(id);
            
            if (group == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(group);
            }
            
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    
    
    // Create

    [HttpPost]
    public async Task<ActionResult> CreateGroup([FromBody] GroupDTO group)
    {
        try
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateGroupAsync(group);
                return Ok(group);
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
    public async Task<ActionResult> UpdateGroup(int id, [FromBody] GroupDTO group)
    {
        try
        {
            GroupDTO updatedGroup = await _repository.UpdateGroupAsync(id, group);

            if (updatedGroup == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(updatedGroup);
            }
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
    
    
    // Delete

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteGroup(int id)
    {
        try
        {
            bool deleteSuccessfully = await _repository.DeleteGroupAsync(id);

            if (!deleteSuccessfully)
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