using ChangeEFCoreHomeWork.Entities;
using System;
using System.Linq;

namespace ChangeEFCoreHomeWork
{
    internal static class ProgramHelpers
    {

        public static bool MainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ProgramHelpers.MainMenu();
                Console.Clear();
                using (var db = new NorthwindContext())
                {
                    Console.WriteLine("Unesi broj ID kojeg zelis da promenis: ");
                    var employee = db.Employees.FirstOrDefault(m => m.EmployeeId == int.Parse(Console.ReadLine()));
                    if (employee == null)
                    {
                        Console.WriteLine("Nisam nasao... ");
                        return;
                    }





                    Console.WriteLine("The first name of the employees is: " + employee.FirstName);


                    Console.WriteLine("Do you want to change the First name of the employee? ");
                    Console.WriteLine("1) yes ");
                    Console.WriteLine("2)No ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Change the First name: ");
                            employee.FirstName = Console.ReadLine();
                            break;


                        case "2":
                            employee.FirstName = employee.FirstName;
                            break;

                        default:
                            break;

                    }


                    Console.Clear();
                    Console.WriteLine("The last name of the employees is: " + employee.LastName);
                    Console.WriteLine("Do you want to change the Last name of the employee? ");
                    Console.WriteLine("1) yes ");
                    Console.WriteLine("2)No ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Change the Last name: ");
                            employee.LastName = Console.ReadLine();
                            break;


                        case "2":
                            employee.LastName = employee.LastName;
                            break;

                        default:
                            break;

                    }
                    Console.Clear();
                    Console.WriteLine("The employee of address is: " + employee.Address);
                    Console.WriteLine("Do you want to change the address of the employee? ");
                    Console.WriteLine("1) yes ");
                    Console.WriteLine("2)No ");


                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Change the address: ");
                            employee.Address = Console.ReadLine();
                            break;

                        case "2":
                            employee.Address = employee.Address;
                            break;

                        default:

                            break;
                    }
                    db.Employees.Update(employee);
                    db.SaveChanges();

                }



            }
        }
    }
}