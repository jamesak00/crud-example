using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class EditPlayer
    {
        ViewPlayer vp = new ViewPlayer();
        public void EditHockey(List<Player> list, int id)
        {

            HockeyPlayer hp = new HockeyPlayer();

            bool validEdit = false;
            foreach (var item in list)
            {
                if (item.PlayerId == id)
                {
                    hp = (HockeyPlayer)item;
                    list.Remove(item);
                    Console.Write("Enter Player Name: ");
                    hp.PlayerName = Console.ReadLine();
                    Console.Write("Enter Team Name: ");
                    hp.TeamName = Console.ReadLine();

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter Games Played: ");
                            hp.GamesPlayed = int.Parse(Console.ReadLine());
                            Console.Write("Enter Assists: ");
                            hp.Assists = int.Parse(Console.ReadLine());
                            Console.Write("Enter Goals: ");
                            hp.Goals = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Valid inputs only!");
                            Console.ReadKey();
                        }

                    }



                    validEdit = true;
                    break;
                }
            }

            if (validEdit)
            {
                list.Add(hp);
                Console.WriteLine("Player has been updated!");
                vp.ViewHockey(list);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid ID");
                Console.ReadKey();
            }

        }
        public void EditBasketball(List<Player> list, int id)
        {
            BasketballPlayer bp = new BasketballPlayer();

            bool validEdit = false;
            foreach (var item in list)
            {
                if (item.PlayerId == id)
                {
                    bp = (BasketballPlayer)item;
                    list.Remove(item);
                    Console.Write("Enter Player Name: ");
                    bp.PlayerName = Console.ReadLine();
                    Console.Write("Enter Team Name: ");
                    bp.TeamName = Console.ReadLine();

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter Games Played: ");
                            bp.GamesPlayed = int.Parse(Console.ReadLine());
                            Console.Write("Enter Field Goals: ");
                            bp.FieldGoals = int.Parse(Console.ReadLine());
                            Console.Write("Enter Three Pointers: ");
                            bp.ThreePointers = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Valid inputs only!");
                            Console.ReadKey();
                        }

                    }



                    validEdit = true;
                    break;
                }
            }

            if (validEdit)
            {
                list.Add(bp);
                Console.WriteLine("Player has been updated!");
                vp.ViewBasketball(list);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid ID");
                Console.ReadKey();
            }
        }
        public void EditBaseball(List<Player> list, int id)
        {
            BaseballPlayer bp = new BaseballPlayer();

            bool validEdit = false;
            foreach (var item in list)
            {
                if (item.PlayerId == id)
                {
                    bp = (BaseballPlayer)item;
                    list.Remove(item);
                    Console.Write("Enter Player Name: ");
                    bp.PlayerName = Console.ReadLine();
                    Console.Write("Enter Team Name: ");
                    bp.TeamName = Console.ReadLine();

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter Games Played: ");
                            bp.GamesPlayed = int.Parse(Console.ReadLine());
                            Console.Write("Enter Runs: ");
                            bp.Runs = int.Parse(Console.ReadLine());
                            Console.Write("Enter Home Runs: ");
                            bp.HomeRuns = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Valid inputs only!");
                            Console.ReadKey();
                        }

                    }


                    validEdit = true;
                    break;
                }
            }

            if (validEdit)
            {
                list.Add(bp);
                Console.WriteLine("Player has been updated!");
                vp.ViewBaseball(list);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid ID");
                Console.ReadKey();
            }
        }
    }
}
