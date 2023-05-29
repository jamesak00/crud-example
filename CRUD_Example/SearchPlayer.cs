using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class SearchPlayer
    {
        public void Search(List<Player> list)
        {
            Console.WriteLine("Enter name to search: ");
            string nameQuery = Console.ReadLine();

            var names = from n in list
                        //From stackoverflow https://stackoverflow.com/questions/444798/case-insensitive-containsstring 
                        where n.PlayerName.Contains(nameQuery, StringComparison.OrdinalIgnoreCase)
                        //----
                        select n;

            var table = new ConsoleTable("Player Type", "Player ID", "Player Name", "Team Name", "Games Played", "Assists", "Goals", "Points");

            var table1 = new ConsoleTable("Player Type", "Player ID", "Player Name", "Team Name", "Games Played", "Field Goals", "Three Pointers", "Points");

            var table2 = new ConsoleTable("Player Type", "Player ID", "Player Name", "Team Name", "Games Played", "Runs", "Home Runs", "Points");

            bool hockExists = false;
            bool baskExists = false;
            bool baseExists = false;

            foreach (var item in names)
            {
                if (item.PlayerType == PlayerType.HockeyPlayer)
                {
                    table.AddRow(item.ToString().Split(","));
                    hockExists = true;
                }

                if (item.PlayerType == PlayerType.BasketballPlayer)
                {
                    table1.AddRow(item.ToString().Split(","));
                    baskExists = true;
                }

                if (item.PlayerType == PlayerType.BaseballPlayer)
                {
                    table2.AddRow(item.ToString().Split(","));
                    baseExists = true;
                }

            }

            if (hockExists)
            {
                table.Write(Format.MarkDown);
            }
            if (baskExists)
            {
                table1.Write(Format.MarkDown);
            }
            if (baseExists)
            {
                table2.Write(Format.MarkDown);
            }
            if (!hockExists && !baskExists && !baseExists)
            {
                Console.WriteLine("Nothing to display.");
            }


            Console.ReadKey();
        }
    }
}
