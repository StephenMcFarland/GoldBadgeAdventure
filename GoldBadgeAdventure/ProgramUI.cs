using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeAdventure
{
    public class ProgramUI
    {
        private static StoryRepository _storyRepo = new StoryRepository();
        private static Story story = new Story();

        int Life = 50;
        int ProjectedSalary = 23;


        public void Run()
        {
            bool running = true;
            while (running)
            {
                if (Life > 99)
                {
                    Console.WriteLine($"Congrats You Lived Through Eleven Fifty! You're on your way to a great projected salary of ${ProjectedSalary},000");
                    Console.ReadLine();
                }
                else if (Life > 25 && Life < 99)
                {
                    Menu();

                }
                else
                {
                    Console.WriteLine("You Should Look into the Other 1150... Per Base Appointment!");
                    Console.ReadLine();
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
                    case 7:
                        //running = false;
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
                "1. Your Choice of \"Fresh\" Fruit.\n" +
                "2. Your Choice of a Delicious Crunch.\n" +
                "3. You decide to Eat a Classmate's Snack.\n");
            int snack = int.Parse(Console.ReadLine());

            switch (snack)
            {
                case 1:
                    Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 4, 10, true);
                    Console.WriteLine($"Good Choice Energy and Cognitive Ability Increase.\n" +
                        $"Life: {Life}\n");
                    break;
                case 2:
                    Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 4, 10, false);
                    Console.WriteLine($"Terrible Choice, Energy and Cognitive Ability Decrease.\n" +
                        $"Life: {Life}\n");
                    break;
                case 3:
                    int number = rnd.Next(1, 3);
                    if (number == 1)
                    {
                        Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 1, 25, true);
                        Console.WriteLine($"Good Choice They Brought in City BBQ.\n" +
                            $"Life: {Life}\n");

                    }
                    else
                    {
                        Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 7, 25, false);
                        Console.WriteLine($"Bad Choice They Brought in Left Over Pork Fried Rice.\n" +
                            $"Life: {Life}\n");

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

