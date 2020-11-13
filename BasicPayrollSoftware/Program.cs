using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    namespace Program
    {
        class Program
        {
            static void Main(string[] args)
            {
                //List of staff objects.
                List<Staff> myStaff = new List<Staff>();

                //FileReader is used to read files.
                FileReader fr = new FileReader();
                int month = 0;
                int year = 0;

                //The user tries to enter a year and a month.
                //If the user doesnt enter an Int32 type as a year an exception error will be prompted.
                //If the user doesnt enter an Int32 type and a value between 1 and 12 , an error will be prompted.
                while(year == 0)
                {
                    System.Console.WriteLine("\nPlease enter the year: ");

                    try
                    {
                        year = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine($"Error entering year: {e.Message}");
                    }
                }
                while (month == 0)
                {
                    System.Console.WriteLine("\nPlease enter the month: ");
                

                    try
                    {
                        month = Convert.ToInt32(Console.ReadLine());

                        if (month < 1 || month > 12)
                        {
                            month = 0;
                            System.Console.WriteLine("Enter a value between 1 and 12, please try again.");
                        }
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine($"Error entering month: {e.Message}");
                    }
                }
                    //Get staff memebers from the ReadFile class.
                    myStaff = fr.ReadFile();

                    //Loop over the different staff members.
                    for (int i = 0; i<myStaff.Count; i++)
                    {
                        try
                        {   
                            // Obtain hours worked for current staff through user input.
                            System.Console.Write($"\nEnter hours worked for {myStaff[i].NameOfStaff}: ");
                            myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine("Hours: " + myStaff[i].HoursWorked);

                            // Calculate the pay for current staff.
                            myStaff[i].CalculatePay();

                            //Write to screen.
                            System.Console.WriteLine(myStaff[i].ToString());
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                            //Decrease counter so the for loop goes over the same staff again.
                            i--;
                        }
                    }

                    //Generate a payslip for each staff member.
                    PaySlip ps = new PaySlip(month, year);
                    ps.GeneratePaySlip(myStaff);
                    ps.GenerateSummary(myStaff);

                    Console.Read();

            }
        }   
    }
    
 