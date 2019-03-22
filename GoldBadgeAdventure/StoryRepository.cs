using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeAdventure
{
    public class StoryRepository
    {

        //public int Life = new int();
        //Life = 50;

        public int MakeRandomNumberAndIncreaseOrDecreaseLife(int life, int first, int second, bool increaseOrDecrease)
        {
            Random rnd = new Random();
            //int life = 0;
            int number = rnd.Next(first, second);
            if (increaseOrDecrease)
            {
                life += number;
            }
            else
            {
                life -= number;
            }



            return life;

        }
    }
}
