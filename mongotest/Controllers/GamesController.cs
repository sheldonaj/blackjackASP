using MongoDB.Bson;
using mongotest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace mongotest.Controllers
{
    [EnableCors(origins: "http://mongotester.azurewebsites.net", headers: "*", methods: "*")]
    public class GamesController : ApiController
    {
        private static readonly GameRepository _games = new GameRepository();

        // GET: api/Games
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Games/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var gameDocument = await _games.GetGame("5");
            if (gameDocument == null)
            {
                return NotFound();
            }
            Game game = new Game(gameDocument);
            var gameResponse = new GameResponse(game);
            return Ok(gameResponse);
        }

        // POST: api/Games
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Games/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Games/5
        public void Delete(int id)
        {
        }
    }
}
