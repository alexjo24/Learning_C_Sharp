    class Manager : Staff
    {

        //Fields
        private const float managerHourlyRate = 50f;

        //Properties
        public int Allowance{get; private set;}

        //Constructur, base keyword used to send the child class parameters to be used in the parent class.
        public Manager(string name) : base(name , managerHourlyRate){
        }

        //Calculates the pay for a manager staff member.
        public override void CalculatePay(){

            //Calculate BasicPay in the parent class with use of the fields in this class, managerHourlyRate in this case.
            base.CalculatePay();
            Allowance = 1000;

            if(HoursWorked > 160){
                TotalPay = BasicPay + Allowance;
            }
        }

        public override string ToString(){
            return base.ToString() + "\n Allowance = " + Allowance;
        }
    }