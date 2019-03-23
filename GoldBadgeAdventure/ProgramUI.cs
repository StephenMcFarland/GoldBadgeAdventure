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
            
            Console.WriteLine("Welcome To Your Day At Eleven Fifty.\n" +
                    "Choose The Beginning of Your Fate:\n");
            for (int i = 1; i < 6; i+=2)
            {
                int rand = rnd.Next(i, i+2);

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
            Console.WriteLine("3.What's my Classmate doing?\n");
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
                    ProjectedSalary += 1;
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
                        ProjectedSalary += 2;
                        Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 1, 25, true);
                        Console.WriteLine($"Good Choice They Brought in City BBQ.\n" +
                            $"Life: {Life}\n");

                    }
                    else
                    {
                        ProjectedSalary -= 1;
                        Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 7, 25, false);
                        Console.WriteLine($"Bad Choice They Brought in Left Over Pork Fried Rice.\n" +
                            $"Life: {Life}\n");

                    }
                    break;

            }

        }
        private void MenuTwo()
        {
            Console.WriteLine("Which project are you ready to tackle?\n" +
                "1. CSS Creature\n" +
                "2. Portfolio project\n" +
                "3. Static store front\n"+
                "4. Business challenges\n");
            int snack = int.Parse(Console.ReadLine());

            switch (snack)
            {
                case 1:
                    MenuTwoOne();
                    break;
                case 2:
                    MenuTwoTwo();
                    break;
                case 3:
                    MenuTwoThree();
                    break;
                case 4:
                    MenuTwoFour();
                    break;
            }


        }

        private void MenuTwoOne()
        {
            Console.WriteLine("You didn't take to the styling right away but after going home and working an extra 3 grueling hours you come out on top with a spectacular piece of work!");
            ProjectedSalary += 5;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 10, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }
        private void MenuTwoTwo()
        {
            Console.WriteLine("Putting off the Portfolio to the last minute comes back to bite!");
            ProjectedSalary -= 2;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 8, false);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");

        }
        private void MenuTwoThree()
        {
            Console.WriteLine("You got the help you needed. You found some good examples and tutorials to follow. Alex says, \"Well done, my friend.\"");
            ProjectedSalary += 15;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 6, 15, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");

        }
        private void MenuTwoFour()
        {
            Console.WriteLine("You got frustrated. You didn't show up. You didn't devise a plan to get the challenges finished. You failed miserably.");
            ProjectedSalary -= 15;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 20, false);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");

        }





        private void MenuThree()
        {
            Console.WriteLine("Which classmate do you encounter?\n" +
                "1. Sarah\n" +
                "2. Justin\n" +
                "3. Adam\n" +
                "4. Sam\n");
            int snack = int.Parse(Console.ReadLine());

            switch (snack)
            {
                case 1:
                    MenuThreeOne();
                    break;
                case 2:
                    MenuThreeTwo();
                    break;
                case 3:
                    MenuThreeThree();
                    break;
                case 4:
                    MenuThreeFour();
                    break;
            }


        }

        private void MenuThreeOne()
        {
            Console.WriteLine("You're playing your music too loud and someone says use ear buds!");
            ProjectedSalary -= 1;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 5, false);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuThreeTwo()
        {
            Console.WriteLine("You're staring at Visual Studio. You've tried several things to push to Git. \"What could I possibly be missing,\" you think to yourself. Justin to the rescue and saves the day! Github skills are in high demand.");
            ProjectedSalary += 25;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 20, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuThreeThree()
        {
            Console.WriteLine("You have to work a peer programming exercise with Adam and create a Choose Your Adventure game. He decides to go home and you're left to work on it by yourself. And totally redeem yourself. You demonstrate poise and leadership, ever so close to that high paying gig. . .");
            ProjectedSalary += 35;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 20, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuThreeFour()
        {
            Console.WriteLine("You decide to leave after lunch and go to the movies. You miss out on valuable learning time. Woops!");
            ProjectedSalary -= 11;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 20, false);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFour()
        {
            Console.WriteLine("Time to drop the kids off at the pool. What's it gonna be?\n" +
                "1. I gotta go\n" +
                "2. I've got the bubble gut\n" +
                "3. Just runnin through me\n" +
                "4. I'll need 45 minutes, somebody open a winduh\n");
            int snack = int.Parse(Console.ReadLine());

            switch (snack)
            {
                case 1:
                    MenuFourOne();
                    break;
                case 2:
                    MenuFourTwo();
                    break;
                case 3:
                    MenuFourThree();
                    break;
                case 4:
                    MenuFourFour();
                    break;
            }


        }

        private void MenuFourOne()
        {
            Console.WriteLine("Way to take care of yourself! Avoid a UTI.");
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 9, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFourTwo()
        {
            Console.WriteLine("You shouldn't have eaten seconds and then all that junk food.");
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 8, 12, false);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFourThree()
        {
            Console.WriteLine("Diarrhea, oh no! What a relief!");
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 10, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFourFour()
        {
            Console.WriteLine("You miss a substantial amount of work time. Your wife texts that she purchased plane tickets to Ireland.");
            ProjectedSalary -= 13;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 18, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFive()
        {
            Console.WriteLine("What's happening in the classroom?\n" +
                "1. Heads down is how I roll\n" +
                "2. Peer programming\n" +
                "3. Presentations allow me time to shine\n" +
                "4. Lectures are my favorite\n");
            int snack = int.Parse(Console.ReadLine());

            switch (snack)
            {
                case 1:
                    MenuFiveOne();
                    break;
                case 2:
                    MenuFiveTwo();
                    break;
                case 3:
                    MenuFiveThree();
                    break;
                case 4:
                    MenuFiveFour();
                    break;
            }


        }

        private void MenuFiveOne()
        {
            Console.WriteLine("This is the best way to cover the most ground. It takes real discipline and stamina to make this happen effectively.");
            ProjectedSalary += 43;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 18, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFiveTwo()
        {
            Console.WriteLine("Peer programming rocks! If you can do this you can do anything.");
            ProjectedSalary += 50;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 18, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFiveThree()
        {
            Console.WriteLine("The nerves get the best of you. You lie about some illness. No show.");
            ProjectedSalary -= 33;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 16, 28, false);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuFiveFour()
        {
            Console.WriteLine("Because you didn't skip the lectures you now know how to do the coding stuff.");
            ProjectedSalary += 17;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 5, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuSix()
        {
            Console.WriteLine("Eat lunch or not eat lunch?\n" +
                "1. Eat lunch\n" +
                "2. Go hang at the dumpster\n");
            int snack = int.Parse(Console.ReadLine());

            switch (snack)
            {
                case 1:
                    MenuSixOne();
                    break;
                case 2:
                    MenuSixTwo();
                    break;
             
            }


        }

        private void MenuSixOne()
        {
            Console.WriteLine("Congratulations for not skipping meals. Stay healthy so you can keeping doing the coding.");
            ProjectedSalary += 6;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 7, 11, true);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }

        private void MenuSixTwo()
        {
            Console.WriteLine("Nothing good will happen at the dumpster. Lose $200. Don't pass go.");
            ProjectedSalary -= 3;
            Life = _storyRepo.MakeRandomNumberAndIncreaseOrDecreaseLife(Life, 2, 18, false);
            Console.WriteLine($"Life: {Life} Projected Salary: ${ProjectedSalary},000\n");
        }
    }
}

