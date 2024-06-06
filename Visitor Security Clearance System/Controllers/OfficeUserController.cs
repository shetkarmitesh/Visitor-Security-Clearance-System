using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Visitor_Security_Clearance_System.Interfaces;
using Visitor_Security_Clearance_System.Entities;
using Visitor_Security_Clearance_System.DTO;

namespace Visitor_Security_Clearance_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeUserController : ControllerBase
    {
        private readonly IOfficeUserService _officeUserService;
        private readonly IMapper _mapper;

        public OfficeUserController(IOfficeUserService officeUserService, IMapper mapper)
        {
            _officeUserService = officeUserService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOfficeUser([FromBody] OfficeUserDTO officeUserDTO)
        {
            try
            {
                var officeUser = _mapper.Map<OfficeUser>(officeUserDTO);
                var result = await _officeUserService.AddOfficeUserAsync(officeUser);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to create office user. " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfficeUserById(string id)
        {
            try
            {
                var result = await _officeUserService.GetOfficeUserByIdAsync(id);
                if (result == null)
                {
                    return NotFound("Office user not found.");
                }

                var model = _mapper.Map<OfficeUserDTO>(result);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to retrieve office user. " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOfficeUser(string id, [FromBody] OfficeUserDTO officeUserDTO)
        {
            try
            {
                var officeUser = _mapper.Map<OfficeUser>(officeUserDTO);
                officeUser.UId = id;

                var result = await _officeUserService.UpdateOfficeUserAsync(officeUser);
                if (result)
                {
                    return Ok("Office user updated successfully.");
                }
                else
                {
                    return NotFound("Office user not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to update office user. " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfficeUser(string id)
        {
            try
            {
                var result = await _officeUserService.DeleteOfficeUserAsync(id);
                if (result)
                {
                    return Ok("Office user deleted successfully.");
                }
                else
                {
                    return NotFound("Office user not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to delete office user. " + ex.Message);
            }
        }
    }
}
