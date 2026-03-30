using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdetAct2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();
            string userInput = "";

            Console.WriteLine("ADET | Activity 2");
            Console.WriteLine("To-Do List");

            while (userInput != "exit")
            {
                Console.WriteLine("\nchoose an option:");
                Console.WriteLine("1. Add a task | 2. View | 3. Clear | Type 'bye' to exit");
                Console.WriteLine("Option: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("enter new task: ");
                        string task = Console.ReadLine();

                        string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                        toDoList.Add($"[{timestamp}] {task}");

                        Console.WriteLine("task added.");
                        break;
                    case "2":
                        Console.WriteLine("to-Do list:");
                        foreach (string item in toDoList)
                        {
                            Console.WriteLine("- " + item);
                        }
                        break;
                    case "3":
                        toDoList.Clear();
                        Console.WriteLine("to-do list cleared.");
                        break;
                    case "bye":
                        userInput = "exit";
                        Console.WriteLine("bye!");
                        break;
                    default:
                        Console.WriteLine("invalid option. pls try again.");
                        break;
                } 

            }
        }
    }
}