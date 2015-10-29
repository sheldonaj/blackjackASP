using blackjack.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace blackjack.Controllers
{
    [EnableCors(origins: "http://mongotester.azurewebsites.net,http://localhost:20350,http://localhost:61892", headers: " *", methods: "*")]
    public class GamesController : ApiController
    {
        private static readonly GameRepository _games = new GameRepository();

        public GamesController()
        {

        }

        // GET: api/Games
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Games/1234
        public async Task<IHttpActionResult> Get(string id)
        {
            var gameDocument = await _games.GetGame(id);
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
