using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
    public class GameInfo
    {
        public GameInfo()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public int PlayersPlayint { get; set; }

        public bool ConnectPlayer(string playerName)
        {
            return true;
        }
    }
}
