using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class DeletePlayer
    {
        public void Delete(List<Player> list, int id)
        {
            ViewPlayer vp = new ViewPlayer();

            bool isDeleted = false;
            foreach (var item in list)
            {
                if (item.PlayerId == id)
                {
                    list.Remove(item);
                    isDeleted = true;
                    break;
                }
            }

            if (isDeleted)
            {
                Console.WriteLine("Player was deleted!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Player Id: {id} does not exist!");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("New list\n");
            vp.ViewAll(list);
            Console.ReadKey();
        }
    }
}
