using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TCCAssociation.Associations;
using TCCAssociation.Associations.Dto;

namespace TCCAssociation.Controllers
{
    [ApiController]
    [Route("api")]
    public class AssociationsController : TCCAssociationControllerBase
    {
        private readonly IAssociationsService _associationsService;

        public AssociationsController(IAssociationsService associationsService)
        {
            _associationsService = associationsService;
        }

        [HttpGet]
        [Route("associations")]
        public async Task<IActionResult> GetAssociations()
        {
            var associations = await _associationsService.GetAssociations();
            if(associations = null)
            {
                return NotFound();
            }
            return Ok(associations);
        }

        [HttpGet]
        [Route("association/{id}")]
        public async Task<IActionResult> GetAssociation(string id)
        {
            var association = await _associationsService.GetAssociation(id);
            if(association == null)
            {
                return NotFound();
            }
            return Ok(association);
        }

        [HttpPost]
        [Route("association")]
        public async Task<IActionResult> CreateAssociation(AssociationDto input)
        {
            if(input == null)
            {
                return BadRequest();
            }
            var association = await _associationsService.CreateAssociation(input);
            if(association == "Invalid Creation of Association")
            {
                return BadRequest();
            }
            return Ok(association);
        }

        [HttpPut]
        [Route("association")]
        public async Task<IActionResult> UpdateAssociation(AssociationDto input)
        {
            if(input == null)
            {
                return BadRequest();
            }
            var association = await _associationsService.UpdateAssociation(input);
            if(association == null)
            {
                return BadRequest();
            }
            return Ok(association);
        }

        [HttpDelete]
        [Route("association")]
        public async Task<IActionResult> DeleteAssociation(string id)
        {
            var association = await _associationsService.DeleteAssociation(id);
            if(association == "Deletion Failed")
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
