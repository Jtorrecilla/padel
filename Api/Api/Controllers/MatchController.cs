using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly ILogger<MatchController> _logger;

        public MatchController(ILogger<MatchController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Match> Get()
        {
            return new List<Match>();
        }
        [HttpPost]
        public Match Create(Match model)
        {
            return model;
        }
        [HttpPut]
        public Match Edit(Match model)
        {
            return model;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public User Get()
        {
            return new User { };
        }
        [HttpPost]
        public User Create(User user)
        {
            return new User { };
        }
        [HttpPut]
        public User Edit(User user)
        {
            return new User { };

        }
        ///TODO Upload Image
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
    
}
