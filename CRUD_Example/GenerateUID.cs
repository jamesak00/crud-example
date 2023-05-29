using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Example
{
    internal class GenerateUID
    {
        public int Generate(List<Player> list)
        {
            int uid = list.Count + 100;

            foreach (var item in list)
            {
                if (item.PlayerId == uid)
                {
                    uid++;
                }
            }
            return uid;
        }
    }
}
