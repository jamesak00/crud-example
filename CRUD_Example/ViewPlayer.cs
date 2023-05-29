using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace CRUD_Example
{
    internal class ViewPlayer
    {
        public void ViewAll(List<Player> list)
        {
            var table = new ConsoleTable("Player Type", "Player ID", "Player Name", "Team Name", "Games Played", "Points");

            foreach (var item in list)
            {
                table.AddRow(item.PlayerType, item.PlayerId, item.PlayerName, item.TeamName, item.GamesPlayed, item.Points());
            }

            table.Write(Format.MarkDown);
        }

        public void ViewHockey(List<Player> list)
        {
            var table = new ConsoleTable("Player Type", "Player ID", "Player Name", "Team Name", "Games Played", "Assists", "Goals", "Points");
            foreach (var item in list)
            {
                if (item.PlayerType == PlayerType.HockeyPlayer)
                {
                    table.AddRow(item.ToString().Split(","));
                }
            }

            table.Write(Format.MarkDown);
        }
        public void ViewBasketball(List<Player> list)
        {
            var table = new ConsoleTable("Player Type", "Player ID", "Player Name", "Team Name", "Games Played", "Field Goals", "Three Pointers", "Points");
            foreach (var item in list)
            {
                if (item.PlayerType == PlayerType.BasketballPlayer)
                {
                    table.AddRow(item.ToString().Split(","));
                }
            }

            table.Write(Format.MarkDown);
        }
        public void ViewBaseball(List<Player> list)
        {
            var table = new ConsoleTable("Player Type", "Player ID", "Player Name", "Team Name", "Games Played", "Runs", "Home Runs", "Points");
            foreach (var item in list)
            {
                if (item.PlayerType == PlayerType.BaseballPlayer)
                {
                    table.AddRow(item.ToString().Split(","));
                }
            }

            table.Write(Format.MarkDown);
        }
    }
}
