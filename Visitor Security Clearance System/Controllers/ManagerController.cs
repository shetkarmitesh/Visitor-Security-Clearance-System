﻿using Microsoft.AspNetCore.Mvc;
using Visitor_Security_Clearance_System.DTO;
using Visitor_Security_Clearance_System.Entities;

namespace Visitor_Security_Clearance_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerService _managerService;
        private readonly IMapper _mapper;

        public ManagerController(IManagerService managerService, IMapper mapper)
        {
            _managerService = managerService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateManager([FromBody] ManagerDTO managerDTO)
        {
            try
            {
                var manager = _mapper.Map<Manager>(managerDTO);
                var result = await _managerService.AddManagerAsync(manager);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to create manager. " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetManagerById(string id)
        {
            try
            {
                var result = await _managerService.GetManagerByIdAsync(id);
                if (result == null)
                {
                    return NotFound("Manager not found.");
                }

                var model = _mapper.Map<ManagerDTO>(result);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to retrieve manager. " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateManager(string id, [FromBody] ManagerDTO managerDTO)
        {
            try
            {
                var manager = _mapper.Map<Manager>(managerDTO);
                manager.UId = id;

                var result = await _managerService.UpdateManagerAsync(manager);
                if (result)
                {
                    return Ok("Manager updated successfully.");
                }
                else
                {
                    return NotFound("Manager not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to update manager. " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManager(string id)
        {
            try
            {
                var result = await _managerService.DeleteManagerAsync(id);
                if (result)
                {
                    return Ok("Manager deleted successfully.");
                }
                else
                {
                    return NotFound("Manager not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to delete manager. " + ex.Message);
            }
        }
    }
}
