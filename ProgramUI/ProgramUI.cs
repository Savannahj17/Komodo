using DeveloperClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    class ProgramUI
    {
        private readonly DeveloperRepo _developerRepo = new DeveloperRepo();
        private void Run()
        {
            //SeedDeveloperList();
            Run();
        }
        public void Run()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Hello, welcome to your application! \n" +
                    "Here is where you can create, read, update, or even delete developers \n" +
                    "and developer teams. Let's start by figuring out which one you are here to \n" +
                    "do now! Enter the number of the option you would like to select. \n" +
                    "1. Show all developers. \n" +
                    "2. Create a new developer. \n" +
                    "3. Remove developer from team. \n" +
                    "4. Add developer to directory. \n" +
                    "5. Exit Program");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowDirectory();
                        break;
                    case "2":
                        CreateNewDeveloper();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 5.");
                        Console.ReadKey();
                        break;
                }
            }

            void CreateNewDeveloper()
            {
                Developer newDeveloper = new Developer();
                // List<Developer> _developers = new List<Developer>();
                Console.WriteLine("Time to add you developers to your directory!\n" +
                    "Please enter the name of the developer: ");
                newDeveloper.Name = Console.ReadLine();

                Console.WriteLine("Please enter the ID associated with this developer: ");
                newDeveloper.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Does this developer have access to Plural Sight? \n" +
                    "Enter 1 for yes" +
                    "Enter 2 for no");
                newDeveloper.PluralSightAccess = bool.Parse(Console.ReadLine());

                _developerRepo.AddDeveloperToDirectory(newDeveloper);
            }
            void ShowDirectory()
            {
                List<Developer> developerDirectory = _developerRepo.GetAllContent();

                foreach(Developer developerVariable in developerDirectory)
                {
                    DisplayContent(developerVariable);
                    Console.WriteLine("---------------------------------------");
                }
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
            }
            void DisplayContent(Developer developer)
            {

                Console.WriteLine($"ID: {developer.Id}");
                Console.WriteLine($"Name: {developer.Name}");
                Console.WriteLine($"Plural Sight Access: {developer.PluralSightAccess}");
            }


            ProgramUI ui = new ProgramUI();
            ui.Run();
            Console.ReadKey();
        }
    }
}
//build out a menu - refer to streaming content
//Build functionality using classes
//Help managers keep track of teams and induviduals
//create collection via cw and user input
//add single or multiple?
//Which one? - provide all ids and names 
//take input and use input to return developer
//save developer to list cw.id and cw.name to allow
//once called in Ui, save to new list and present options
//Repo present info, UI iterates through based on respose
//Repo pattern video