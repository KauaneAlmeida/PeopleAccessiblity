using DisabledPeopleRegister.Dtos.Activities;
using DisabledPeopleRegister.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DisabledPeopleRegister.Controllers
{
    [Route("atividades")]
    public class AtividadesController(IActivitiesService activitiesService) : Controller
    {
        //Create
        [HttpPost("add")]
        public IActionResult AddActivity([FromBody] CreateActivityDto createActivityDto)
        {
            activitiesService.Add(createActivityDto);
            return Ok();
        }
        
        //Read
        [HttpGet("get-by-id/:id")]
        public IActionResult GetActivityById([FromQuery] int id)
        {
            var activity = activitiesService.GetById(id);
            return Ok(activity);
        }

        //Update
        [HttpPut("update-by-id/:id")]
        public IActionResult UpdateActivity([FromQuery] int id, [FromBody] UpdateActivityDto updateActivityDto)
        {
            activitiesService.UpdateById(id, updateActivityDto);
            return Ok();
        }

        //Delete
        [HttpDelete("delete-by-id/:id")]
        public IActionResult DeleteActivity([FromQuery] int id)
        {
            activitiesService.DeleteById(id);
            return Ok();
        }
    }
}