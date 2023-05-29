using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class BaseballPlayer : Player
    {
        public int Runs { get; set; }
        public int HomeRuns { get; set; }

        internal override int Points()
        {
            return (Runs - HomeRuns) + (2 * HomeRuns);
        }

        public override string ToString()
        {
            return $"{PlayerType}, {PlayerId}, {PlayerName}, {TeamName}, {GamesPlayed}, {Runs}, {HomeRuns}, {Points()}";
        }
    }
}
