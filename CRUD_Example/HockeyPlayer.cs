using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class HockeyPlayer : Player
    {
        public int Assists { get; set; }
        public int Goals { get; set; }

        internal override int Points()
        {
            return Assists + (2 * Goals);
        }

        public override string ToString()
        {
            return $"{PlayerType}, {PlayerId}, {PlayerName}, {TeamName}, {GamesPlayed}, {Assists}, {Goals}, {Points()}";
        }
    }
}
