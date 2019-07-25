﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab_9_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while(cont)
            { 
             
                List<string> studentNames = new List<string>
                {
                    "Alex", "Bailey", "Evan", "John", "Langston"
                };

                List<string> studentFood = new List<string>
                {
                    "Pizza","Hot Dog","Hamburger","Cheeseburger","milkshake"
                };

                List<string> studentHometown = new List<string>
                {
                    "Detroit", "Berkley","Des Moines", "Los Angeles","Southfield"
                };

                List<string> studentFavColor = new List<string>
                {
                    "red", "blue", "green", "yellow", "purple"
                };

                int studentNum = GetStudentNum("Please input the number corresponding to the student you'd like to know more about \n 1. Alex \n 2. Bailey \n 3. Evan \n 4. John \n 5. Langston");
                string studentName = GetStudentName(studentNum, studentNames);
                Console.WriteLine($"What would you like to know about {studentName}? Please input the corresponding value. \n 1. Favorite food \n 2.Hometown \n 3. Favorite Color \n 4. All of the above");
                string foodChoice = "";
                string hometown = "";
                string colorChoice = "";
                bool cont2 = true;
                while (cont2)
                {
                    try
                    {
                        int knowMore = int.Parse(Console.ReadLine());

                        if (knowMore == 1)
                        {
                            foodChoice = studentFood[studentNum];
                            cont2 = false;
                        }
                        else if (knowMore == 2)
                        {
                            hometown = studentHometown[studentNum];
                            cont2 = false;
                        }
                        else if (knowMore == 3)
                        {
                            colorChoice = studentFavColor[studentNum];
                            cont2 = false;
                        }
                        else if (knowMore == 4)
                        {
                            foodChoice = studentFood[studentNum];
                            hometown = studentHometown[studentNum];
                            colorChoice = studentFavColor[studentNum];
                            cont2 = false;
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid answer, please give a number between 1 and 4.");
                            continue;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That is not a valid response, please give a number between 1 and 4");
                        continue;
                    }
                }
            }

            

        }
        public static int GetStudentNum(string message)
        {
            Console.WriteLine(message);
            bool cont = true;
            int studentNum = 0;
            while(cont)
            {
                string usrInput = Console.ReadLine();
                try
                {
                    if (studentNum >= 1 && studentNum <= 5)
                    {
                        studentNum = int.Parse(usrInput);
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid input, please choose one of the students numbers. [1-5]");
                        continue;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("That is an invalid input, please choose one of the students numbers. [1-5]");
                    continue;
                }
            }
            return studentNum;
        }
        public static string GetStudentName(int studentNum, List<string> studentNames)
        {
            string studentName = studentNames[studentNum];
            return studentName;

        }
        public static int KnowMore(string message)
        {
            Console.WriteLine(message);
            bool cont = true;
            int choice = 0;
            while (cont)
            {
                string usrInput = Console.ReadLine();
                try
                {
                    choice = int.Parse(usrInput);
                    if(choice >= 1 && choice <= 4)
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("That was an invalid number, please input a number between 1 and 4.");
                        continue;
                    }
                    
                }
                catch(FormatException)
                {
                    Console.WriteLine("That was an invalid input, please input a number between 1 and 4.");
                    continue;
                }
                
                

            }
            return choice;
        }
        public static string HandleDataChoice(int knowMoreNum)
        {
        }
    }
}
