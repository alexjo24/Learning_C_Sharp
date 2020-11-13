using System;

    class Staff
    {   
        //Fields
        private int hWorked;
        private float hourlyRate = 30f;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        

        //Properties
        public float TotalPay{get; protected set;}
        public float BasicPay{get; private set;}
        public string NameOfStaff{get; private set;}

        //Property, hWorked is the backing field.
        public int HoursWorked{
            get{return hWorked;}
            set
            {
                if(value > 0){
                    hWorked = value;
                }else{
                    hWorked = 0;
                }
            }
        }



        //Constructur
        public Staff(string name , float rate){

            NameOfStaff = name;
            hourlyRate = rate;

        }

        //Method, virtual enables this method to be overridden in derived classes (Polymorphism)
        public virtual void CalculatePay(){
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        //Method, override keyword: overrides the method in the parent class.
        public override string ToString(){
            return "\nName of staff: " + NameOfStaff
                + "\nHourly rate = " + hourlyRate
                + ", Hours worked = " + hWorked
                + "\nBasic pay = " + BasicPay 
                + "\nTotal pay = " + TotalPay;
        }
    }