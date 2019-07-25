using System;
using System.Collections.Generic;

namespace Lab_8_Get_to_know_your_classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string> { "Dan", "Zack", "Evan", "Mitch", "Mallory" };
            bool cont = true;
            while (cont)
            {

                Console.WriteLine("Please choose the corresponding number to the student you would like to learn more about:" + "\n" + "1. Dan" + "\n" + "2. Zack" + "\n" + "3. Evan" + "\n" + "4. Mitch" + "\n" + "5. Mallory");
                string studentNum1 = Console.ReadLine();
                int studentNum = 0;
                try
                {
                    studentNum = int.Parse(studentNum1);
                    if (studentNum < 1 || studentNum > nameList.Count-1)
                    {
                        Console.WriteLine("That was outside of the given range, let's try again.");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not valid, let's try again.");
                    continue;
                }

                string studentName = ChooseStudent((studentNum - 1), nameList);
                Console.WriteLine($"The student's name is {studentName}");

                //asking to know favorite food
                string studentFood = ChooseFood($"Would you like to know {studentName}'s favorite food?", (studentNum - 1));
                if (studentFood != "")
                {
                    Console.WriteLine($"{studentName}'s favorite food is {studentFood}.");
                }

                //asking to know hometown
                string studentHometown = ChooseHometown($"Would you like to know which town {studentName} grew up in?", (studentNum - 1));
                if (studentHometown != "")
                {
                    Console.WriteLine($"{studentName}'s hometown is {studentHometown}.");
                }

                //asking to know favorite drink
                string studentDrink = ChooseDrink($"Would you like to know {studentName}'s favorite drink?", (studentNum - 1));
                if (studentDrink != "")
                {
                    Console.WriteLine($"{studentName}'s favorite drink is {studentDrink}.");
                }

                //asking to continue
                //cont = ChooseContinue();
                Console.WriteLine("Would you like to run this program again? Press 1 and enter");
                Console.WriteLine("Would you also like to add another student to the list of names? Press 2 and enter");
                Console.WriteLine("If you would like to end this program, press 3 and enter");
                bool cont2 = true;
                while (cont2)
                {
                    string uInput = Console.ReadLine();
                    if (uInput == "1")
                    {
                        cont2 = false;
                    }
                    else if (uInput == "2")
                    {
                        Console.WriteLine("What name would you like to add?");
                        string newName = Console.ReadLine();
                        nameList.Add(newName);
                        cont2 = false;
                    }
                    else if (uInput == "3")
                    {
                        Console.WriteLine("Goodbye.");
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please give a number between 1 and 3.");
                        continue;
                    }
                }

            }
        }
        public static string ChooseStudent(int studentNum, List<string> nameList)
        {
            //List<string> nameList = new List<string> { "Dan", "Zack", "Evan", "Mitch", "Mallory" };
            bool cont = true;
            string studentName = "";
            while (cont)
            {
                try
                {
                    studentName = nameList[studentNum];
                    cont = false;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That was not valid, let's try again.");
                    continue;
                }
            }
            return studentName;

        }
        public static string ChooseFood(string message, int studentNum)
        {
            Console.WriteLine(message);
            List<string> foodList = new List<string> { "hot dog", "cheeseburger", "milkshake", "curry", "tacos" };
            string foodChoice = "";
            bool cont = true;
            while (cont)
            {
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    foodChoice = foodList[studentNum];
                    cont = false;
                }
                else if (response == "n")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid response, let't try that again.");
                    continue;
                }
            }
            return foodChoice;
        }
        public static string ChooseHometown(string message, int studentNum)
        {
            Console.WriteLine(message);
            List<string> hometownList = new List<string> { "Detroit", "Chicago", "Boston", "Los Angeles", "Seattle" };
            string hometown = "";
            bool cont = true;
            while (cont)
            {
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    hometown = hometownList[studentNum];
                    cont = false;
                }
                else if (response == "n")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid response, let't try that again.");
                    continue;
                }
            }
            return hometown;
        }
        public static string ChooseDrink(string message, int studentNum)
        {
            Console.WriteLine(message);
            List<string> drinkList = new List<string> { "Coke", "Pepsi", "Sprite", "Jeager", "Red-Bull" };
            string drink = "";
            bool cont = true;
            while (cont)
            {
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    drink = drinkList[studentNum];
                    cont = false;
                }
                else if (response == "n")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid response, let't try that again.");
                    continue;
                }
            }
            return drink;

        }
        public static bool ChooseContinue()
        {
            bool cont = true;
            bool cont1 = true;
            while (cont1)
            {
                Console.WriteLine("Would you like to learn about another student?");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    cont = true;
                    cont1 = false;
                }
                else if (response == "n")
                {
                    cont = false;
                    cont1 = false;
                }
                else
                {
                    Console.WriteLine("That was not a valid input, please try again.");
                    continue;
                }

            }
            return cont;
        }
    }
}
