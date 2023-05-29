using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class AddPlayer
    {

        public void Add(List<Player> list, string choice)
        {
            GenerateUID guid = new GenerateUID();
            ViewPlayer vp = new ViewPlayer();
            string playerName;
            string teamName;
            int gamesPlayed;

            while (true)
            {
                try
                {
                    Console.Write("Enter Player Name: ");
                    playerName = Console.ReadLine();
                    Console.Write("Enter Team Name: ");
                    teamName = Console.ReadLine();
                    Console.Write("Enter Games Played: ");
                    gamesPlayed = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valid inputs only please!");
                    Console.ReadKey();
                }
            }

            if (choice == "1")
            {
                HockeyPlayer hockp = new HockeyPlayer();

                while (true)
                {
                    try
                    {

                        hockp.PlayerId = guid.Generate(list);
                        hockp.PlayerType = PlayerType.HockeyPlayer;
                        hockp.PlayerName = playerName;
                        hockp.TeamName = teamName;
                        hockp.GamesPlayed = gamesPlayed;
                        Console.Write("Enter Assists: ");
                        hockp.Assists = int.Parse(Console.ReadLine());
                        Console.Write("Enter Goals: ");
                        hockp.Goals = int.Parse(Console.ReadLine());

                        list.Add(hockp);
                        vp.ViewAll(list);
                        break;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Valid inputs only please!");
                        Console.ReadKey();
                    }
                }

            }
            if (choice == "2")
            {
                BasketballPlayer baskp = new BasketballPlayer();


                while (true)
                {
                    try
                    {

                        baskp.PlayerId = guid.Generate(list);

                        baskp.PlayerType = PlayerType.BasketballPlayer;
                        baskp.PlayerName = playerName;
                        baskp.TeamName = teamName;
                        baskp.GamesPlayed = gamesPlayed;
                        Console.Write("Enter Three Pointers: ");
                        baskp.ThreePointers = int.Parse(Console.ReadLine());
                        Console.Write("Enter Field Goals: ");
                        baskp.FieldGoals = int.Parse(Console.ReadLine());

                        list.Add(baskp);
                        vp.ViewAll(list);
                        break;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Valid inputs only please!");
                        Console.ReadKey();
                    }
                }
            }



            if (choice == "3")
            {
                BaseballPlayer basep = new BaseballPlayer();

                while (true)
                {
                    try
                    {

                        basep.PlayerId = guid.Generate(list);

                        basep.PlayerType = PlayerType.BaseballPlayer;
                        basep.PlayerName = playerName;
                        basep.TeamName = teamName;
                        basep.GamesPlayed = gamesPlayed;
                        Console.Write("Enter Home Runs: ");
                        basep.HomeRuns = int.Parse(Console.ReadLine());
                        Console.Write("Enter Runs: ");
                        basep.Runs = int.Parse(Console.ReadLine());

                        list.Add(basep);
                        vp.ViewAll(list);
                        break;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Valid inputs only please!");
                        Console.ReadKey();
                    }
                }

            }
        }

    }
}
