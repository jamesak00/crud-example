using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal abstract class Player
    {
        public PlayerType PlayerType { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public int GamesPlayed { get; set; }

        internal abstract int Points();
    }
    public enum PlayerType
    {
        HockeyPlayer,
        BasketballPlayer,
        BaseballPlayer
    }
}
