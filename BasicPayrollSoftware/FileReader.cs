    using System.Collections.Generic;
    using System.IO;
    using System;
    
    class FileReader
    {
        //The method reads a text file with staff names and roles.
        //Depending on the role of a staff memeber, different objects are created. Manager object or Admin object. 
        //Pay slips are calculated differently depending on if a staffmemeber is a Manager or Admin.
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "staff.txt";
            string[] separator = {","};

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream == false)
                    {

                        result = sr.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
                        if (result[1] == "Manager"){
                            
                            myStaff.Add(new Manager(result[0]));

                        }else if(result[1] == "Admin"){
                            myStaff.Add(new Admin(result[0]));
                        }else{

                            System.Console.WriteLine("Cant find role");
                        }

                    }
                    sr.Close();
                }
            }else{
                System.Console.WriteLine("Cant find the file.");
            }

            return myStaff;

        }
    }