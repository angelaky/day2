using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("blizzard", "blizzardonlinecasino.com", "/onlinecasino.com");
            GameInfo info = new GameInfo();
            info.ConnectPlayer("viktor");
            game.Gameinfo = info;            
            
            string json = JsonConvert.SerializeObject(game, Formatting.Indented);

            var newGame = JsonConvert.DeserializeObject<Game>(json);

            Console.WriteLine(json);
        }
    }
}
