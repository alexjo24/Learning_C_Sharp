using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
    
    class PaySlip
    {   
        private int month;
        private int year;

        enum MonthsOfYear
        {
            JAN = 1, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC
        }
        public PaySlip(int payMonth, int payYear){
            month = payMonth ;
            year = payYear;
        }

        //Generate a pay slip for each staff memeber.
        public void GeneratePaySlip(List<Staff> myStaff){
            string path;

            foreach (Staff st in myStaff)
            {
                path = st.NameOfStaff + ".txt";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine($"PAYSLIP FOR {(MonthsOfYear)month} {year}");
                    sw.WriteLine("=============================");
                    sw.WriteLine($"Name of Staff: {st.NameOfStaff}");
                    sw.WriteLine($"Hours worked: {st.HoursWorked}");
                    sw.WriteLine("");
                    sw.WriteLine($"Basic Pay: {st.BasicPay:C}");

                    if (st.GetType() == typeof(Manager))
                    {
                        sw.WriteLine($"Allowance: {((Manager)st).Allowance:C}");
                    }else if(st.GetType() == typeof(Admin))
                    {
                        sw.WriteLine($"Overtime: {((Admin)st).Overtime:C}");
                    }
                    sw.WriteLine("");
                    sw.WriteLine("=============================");
                    sw.WriteLine($"Total Pay: {st.TotalPay:C}");
                    sw.WriteLine("=============================");
                    sw.Close();
                }
            }
        }

        //Generates a summary .txt file with each staff memeber who worked less than 10 hours.
        public void GenerateSummary(List<Staff> myStaff)
        {
        
            var workTime =
                from st in myStaff
                where st.HoursWorked < 10
                orderby st.NameOfStaff ascending
                select new {st.NameOfStaff, st.HoursWorked};

                string path = "summary.txt";

                using(StreamWriter sw = new StreamWriter(path)){
                    sw.WriteLine("Staff with less than 10 hours worked");
                    sw.WriteLine("");

                    foreach (var st in workTime){
                        sw.WriteLine($"Name of Staff: {st.NameOfStaff}, Hours worked: {st.HoursWorked}");
                    }
                    sw.Close();
                }
        }

    public override string ToString()
    {
        return "\n month = " + month + " year = " + year;
    }





}