using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeAdventure
{
    public class StoryRepository
    {

        public int Life = new int();

        public int MakeRandomNumberAndIncreaseOrDecreaseLife(int first, int second, bool increaseOrDecrease)
        {
            Random rnd = new Random();
            int number = rnd.Next(first, second);
            if (increaseOrDecrease)
            {
                Life += number;
            }
            else
            {
                Life -= number;
            }



            return Life;

        }
    }
}
