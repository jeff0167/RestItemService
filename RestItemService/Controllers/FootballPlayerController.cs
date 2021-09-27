using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Csharp_UnitTest;
using RestItemService.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private readonly IManageFootballPlayers mgr = new ManageFootballPlayers();

        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return mgr.Get();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public bool Post(FootballPlayer value) // when creating a new object we set the id with the help of GlobalID
        {
            value.Id = mgr.GenerateID(); // we set the id before it is created in the manager
            return mgr.Create(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public bool Put(int id, FootballPlayer value) // if we wanted to update the id as well we need to make a check if the id not already exist and throw and error if that is the case
        {
            return mgr.Update(id, value);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return mgr.Delete(id);
        }
    }
}
