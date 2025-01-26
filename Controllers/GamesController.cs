using GamesStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        [HttpGet("AllGames")]
        public ActionResult<List<Game>> Read()
        {
            return Game.Read();
        }

        // GET: api/Games/UserGames
        [HttpGet("UserGames")]
        public ActionResult<List<Game>> GetUserGames(int userId)
        { 
                List<Game> userGames = Game.GetUserGames(userId);

                return userGames;
            
        }
        //post api/Games/UserBuyGame
        [HttpPost("UserBuyGame")]
        public int UserBuyGame(int userId, int appID)
        {
            return Game.UserBuyGame(userId, appID);
        }
        
        [HttpGet("GetByPrice")]
        public ActionResult<List<Game>> GetByPrice(int UserID, float Price)
        {
            return Game.GetGamesByPrice(UserID, Price);
        }

        // GET api/Games/GetByRank?rank=<value>
        [HttpGet("GetByRank")]
        public ActionResult<List<Game>> GetByRank(int UserID, int Rank)
        {
            return Game.GetGamesByRank(UserID, Rank);
        }


        // DELETE: api/Games/MyGames/<id>
        [HttpDelete("DeleteGame")]
        public int RemoveFromMyGames(int UserId, int AppId)
        {
            
            return Game.DeleteGameById(UserId, AppId);
            
        }
        [HttpGet("GamesBI")]
        public object GamesBI()
        {
            return Game.GamesBI();
        }

    }
}
