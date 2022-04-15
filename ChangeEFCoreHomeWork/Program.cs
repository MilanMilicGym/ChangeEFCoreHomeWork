using System;
using System.Linq;
using ChangeEFCoreHomeWork.Entities;

namespace ChangeEFCoreHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izmena postojeceg employee");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ProgramHelpers.MainMenu();
            }
            Console.WriteLine("Bye!");
        }
    }











}
    
        




    

    
