using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramAdventure
{
    public class ProgramUI
    {
        StoryRepository _storyRepo = new StoryRepository();

        int life = 50;
        int projectSalary = 23;


        public void Run()
        {
            bool running = true;
            while (running)
            {
                if (life > 99)
                {
                    Console.WriteLine("Congrat You Lived Through Eleven Fifty");
                }
                else if (life > 25 && life < 99)
                {
                    Menu();

                }
                else
                {
                    Console.WriteLine("You Should Look into the Other 1150... Per Base Appointment!");
                }

            }
        }
        private void Menu()
        {
            Random rnd = new Random();
            //int menuNumber = rnd.Next(1, 7);
            //int menuNumberTwo = rnd.Next(1, 7);
            //int menuNumberThree = rnd.Next(1, 7);
            Console.WriteLine("Welcome To Your Day At Eleven Fifty.\n" +
                    "Choose The Beginning of Your Fate:\n");
            for (int i = 1; i < 4; i++)
            {
                int rand = rnd.Next(1, 7);

                switch (rand)
                {
                    case 1:
                        MenuOptionOne();
                        break;
                    case 2:
                        MenuOptionTwo();
                        break;
                    case 3:
                        MenuOptionThree();
                        break;
                    case 4:
                        MenuOptionFour();
                        break;
                    case 5:
                        MenuOptionFive();
                        break;
                    case 6:
                        MenuOptionSix();
                        break;

                }
            }

            int yourFate = int.Parse(Console.ReadLine());

            switch (yourFate)
            {
                case 1:
                    MenuOne();
                    break;
                case 2:
                    MenuTwo();
                    break;
                case 3:
                    MenuThree();
                    break;
                case 4:
                    MenuFour();
                    break;
                case 5:
                    MenuFive();
                    break;
                case 6:
                    MenuSix();
                    break;

            }
        }
        private void MenuOptionOne()
        {
            Console.WriteLine("1.The Snack Room Awaits.\n");

        }
        private void MenuOptionTwo()
        {
            Console.WriteLine("2.Oh NO not Another Project.\n");
        }
        private void MenuOptionThree()
        {
            Console.WriteLine("3.Interrupted By a Classmate.\n");
        }
        private void MenuOptionFour()
        {
            Console.WriteLine("4.Your Bladder Controls Your Fate.\n");
        }
        private void MenuOptionFive()
        {
            Console.WriteLine("5.Classroom Marathon\n");
        }
        private void MenuOptionSix()
        {
            Console.WriteLine("6.Time for Lunch\n");
        }
        private void MenuOne()
        {
            Random rnd = new Random();

            Console.WriteLine("What Snack Would you Like?\n" +
                "1.Your Choice of \"Fresh\" Fruit." +
                "2. Your Choice of a Delicious Crunch." +
                "3. You decide to Eat a Classmate Snack.");
            int snack = int.Parse(Console.ReadLine());

            switch (snack)
            {
                case 1:
                    life += 8;
                    Console.WriteLine($"Good Choice Energy and Cognitive Ability Increase by 8 points.\n" +
                        $"Life: {life}");
                    break;
                case 2:
                    life -= 4;
                    Console.WriteLine($"Terrible Choice Energy and Cognitive Ability Decrease by 4 points.\n" +
                        $"Life: {life}");
                    break;
                case 3:
                    int increase = _storyRepo.MakeRandomNumber(1, 25);

                    int number = rnd.Next(1, 3);
                    if (number == 1)
                    {
                        life += increase;
                        Console.WriteLine($"Good Choice They Brought in City BBQ." +
                            $"Life: {life}");

                    }
                    else
                    {
                        life -= increase;
                        Console.WriteLine($"Bad Choice They Brought in Left Over Pork Fried Rice." +
                            $"Life: {life}");

                    }
                    break;

            }

        }
        private void MenuTwo()
        {

        }
        private void MenuThree()
        {

        }
        private void MenuFour()
        {

        }
        private void MenuFive()
        {

        }
        private void MenuSix()
        {

        }

    }
}
}
