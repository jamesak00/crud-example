using System.Collections.Generic;
using System;

namespace CRUD_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();
            AddPlayer ap = new AddPlayer();
            ViewPlayer vp = new ViewPlayer();
            DeletePlayer dp = new DeletePlayer();
            EditPlayer ep = new EditPlayer();
            SearchPlayer sp = new SearchPlayer();
            GenerateUID guid = new GenerateUID();

            HockeyPlayer hockp = new HockeyPlayer();
            BasketballPlayer baskp = new BasketballPlayer();
            BaseballPlayer basep = new BaseballPlayer();
            BasketballPlayer baskp1 = new BasketballPlayer();
            BaseballPlayer basep1 = new BaseballPlayer();

            hockp.PlayerId = guid.Generate(playerList);
            hockp.PlayerType = PlayerType.HockeyPlayer;
            hockp.PlayerName = "Player 1";
            hockp.TeamName = "Team Player 1";
            hockp.GamesPlayed = 100;
            hockp.Assists = 60;
            hockp.Goals = 20;
            playerList.Add(hockp);


            baskp1.PlayerId = guid.Generate(playerList);
            baskp1.PlayerType = PlayerType.BasketballPlayer;
            baskp1.PlayerName = "Player 2";
            baskp1.TeamName = "Team Player 2";
            baskp1.GamesPlayed = 35;
            baskp1.FieldGoals = 30;
            baskp1.ThreePointers = 24;
            playerList.Add(baskp1);

            basep1.PlayerId = guid.Generate(playerList);
            basep1.PlayerType = PlayerType.BaseballPlayer;
            basep1.PlayerName = "Player 3";
            basep1.TeamName = "Team Player 3";
            basep1.GamesPlayed = 12;
            basep1.Runs = 2;
            basep1.HomeRuns = 4;
            playerList.Add(basep1);




            bool mainExit = true;
            while (mainExit)
            {
                Console.Clear();
                Console.WriteLine("Choose an option\n1. Add Player\n2. Edit Player\n3. Delete Player\n4. View Player\n5. Search Player\n6. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    //Add
                    case "1":
                        bool exit1 = true;
                        while (exit1)
                        {
                            Console.Clear();
                            Console.WriteLine("Choose an option\n1. Add Hockey Player\n2. Add Basketball Player\n3. Add Baseball Player\n4. Back to Main Menu");
                            string choice1 = Console.ReadLine();
                            switch (choice1)
                            {
                                case "1":
                                    ap.Add(playerList, choice1);
                                    break;
                                case "2":
                                    ap.Add(playerList, choice1);
                                    break;
                                case "3":
                                    ap.Add(playerList, choice1);
                                    break;
                                case "4":
                                    Console.Clear();
                                    exit1 = false;
                                    break;
                                default:
                                    Console.WriteLine("Choose again");
                                    Console.ReadKey();
                                    break;
                            }
                            exit1 = false;
                        }
                        break;
                    //Edit    
                    case "2":
                        bool exit2 = true;
                        while (exit2)
                        {
                            Console.Clear();
                            Console.WriteLine("Choose an option\n1. Edit Hockey Player\n2. Edit Basketball Player\n3. Edit Baseball Player\n4. Back to Main Menu");
                            string choice2 = Console.ReadLine();
                            int id = 0;
                            switch (choice2)
                            {
                                case "1":
                                    vp.ViewHockey(playerList);
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Enter player id: ");
                                            id = int.Parse(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Enter a valid ID");
                                            Console.ReadKey();
                                        }
                                    }

                                    ep.EditHockey(playerList, id);

                                    break;
                                case "2":
                                    vp.ViewBasketball(playerList);
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Enter player id: ");
                                            id = int.Parse(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Enter a valid ID");
                                            Console.ReadKey();
                                        }
                                    }

                                    ep.EditBasketball(playerList, id);

                                    break;
                                case "3":
                                    vp.ViewBaseball(playerList);
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Enter player id: ");
                                            id = int.Parse(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Enter a valid ID");
                                            Console.ReadKey();
                                        }
                                    }

                                    ep.EditBaseball(playerList, id);

                                    break;
                                case "4":
                                    exit2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Valid inputs only!");
                                    Console.ReadKey();
                                    break;
                            }

                        }
                        break;

                    //Delete
                    case "3":
                        bool exit3 = true;
                        while (exit3)
                        {
                            Console.Clear();
                            vp.ViewAll(playerList);
                            int id = 0;
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Choose a player to delete: ");
                                    id = int.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("Try again");
                                    Console.ReadKey();

                                }
                            }

                            dp.Delete(playerList, id);
                            break;
                        }

                        break;
                    //View
                    case "4":
                        bool exit4 = true;
                        while (exit4)
                        {
                            Console.Clear();
                            Console.WriteLine("Choose an option\n1. View Hockey Player\n2. View Basketball Player\n3. View Baseball Player\n4. View All Players\n5. Back to Main Menu");
                            string choice4 = Console.ReadLine();
                            switch (choice4)
                            {
                                case "1":
                                    vp.ViewHockey(playerList);
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    vp.ViewBasketball(playerList);
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    vp.ViewBaseball(playerList);
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    vp.ViewAll(playerList);
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    exit4 = false;
                                    break;
                                default:
                                    Console.WriteLine("Valid inputs only!");
                                    Console.ReadKey();
                                    break;
                            }
                        }

                        break;
                    //Search
                    case "5":
                        bool exit5 = true;
                        while (exit5)
                        {
                            sp.Search(playerList);
                            exit5 = false;
                        }
                        break;
                    //Exit
                    case "6":
                        mainExit = false;
                        Console.Clear();
                        Console.WriteLine("Thanks for your time!");
                        Console.ReadKey();
                        break;
                    //Invalid
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        Console.ReadKey();
                        break;
                }
            }



        }
    }
}