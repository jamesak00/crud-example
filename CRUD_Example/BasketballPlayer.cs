using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class BasketballPlayer : Player
    {
        public int FieldGoals { get; set; }
        public int ThreePointers { get; set; }

        internal override int Points()
        {
            return (FieldGoals - ThreePointers) + (2 * ThreePointers);
        }

        public override string ToString()
        {
            return $"{PlayerType}, {PlayerId}, {PlayerName}, {TeamName}, {GamesPlayed}, {FieldGoals}, {ThreePointers}, {Points()}";
        }
    }
}
