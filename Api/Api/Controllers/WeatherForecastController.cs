using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<GroupController> _logger;

        public GroupController(ILogger<GroupController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Group> All()
        {
            return new List<Group>();
        }
        [HttpGet("filter")]
        public IEnumerable<Group> Filter(FilterModel model)
        {
            return new List<Group>();
        }
        [HttpPost()]
        public IEnumerable<Group> Add(Group model)
        {
            return new List<Group>();
        }
        [HttpPut()]
        public IEnumerable<Group> Edit(Group model)
        {
            return new List<Group>();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
        [HttpPost("{id}/add-member")]
        public IEnumerable<Group> AddMember(Guid id, User model)
        {
            return new List<Group>();
        }
        [HttpDelete("{id}/{user}/delete-member")]
        public IActionResult DeleteMember(Guid id, Guid user)
        {
            return Ok();
        }
        [HttpPost("{id}/add-admin")]
        public IEnumerable<Group> AddAdmin(Guid id, User model)
        {
            return new List<Group>();
        }
        [HttpDelete("{id}/{user}/delete-admin")]
        public IActionResult DeleteAdmin(Guid id, Guid user)
        {
            return Ok();
        }
    }
    public class FilterModel
    {
        public string GroupName { get; set; }


        public string UserName { get; set; }
    }
}
