using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperPOCO;
using DevTeamPOCO;
using DeveloperRepo;
using DevTeamRepo;

namespace ProgramUI
{
    public class ProgramUI
    {
        private bool _keepRunning = false;
        
        public void Main(string[] args)
        {
            SeedDevelopers();
            RunProgram();
        }

        public void RunProgram()
        {
            ShowWelcome();
            ShowMenu();
        }

        public void ShowWelcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Komodo Insurance program\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
            _keepRunning = true;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose a menu option\n" +
                "1 - Add Developer to Team\n" +
                "2 - Remove Developer from Team\n" +
                "");
        }





        public void SeedDevelopers()
        {
            Developer dev1 = new Developer(0, "Bob Smith");
            Developer dev2 = new Developer(1, "John Brown", SoftwareList.Pluralsight);
            Developer dev3 = new Developer(2, "Tom Billings", SoftwareList.Other);
            Developer dev4 = new Developer(3, "Bill Tommings");
            Developer dev5 = new Developer(4, "Phil");


        }
    }
}
