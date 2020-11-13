    class Admin : Staff
    {   
        //Fields
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;

        //Properties
        public float Overtime{get; private set;}

        //Constructur, base keyword used to send the child class parameters to be used in the parent class.
        public Admin(string name): base(name, adminHourlyRate){
            
        }
        //Calculates the pay for a admin staff member.
        public override void CalculatePay(){

            //Calculate BasicPay in the parent class with use of the fields in this class, adminHourlyRate in this case.
            base.CalculatePay();
            

            if(HoursWorked > 160){
                Overtime = overtimeRate * (HoursWorked - 160);
                TotalPay = BasicPay + Overtime;
            }
        }

        public override string ToString(){
                    
            return base.ToString() + "\n Overtime = " + Overtime;
        
        }
    }