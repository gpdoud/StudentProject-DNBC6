using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {

            Student brailee = new Student();
            brailee.SetStatus("current");
            brailee.SetStatus("Current");
            brailee.SetStatus("CURRENT");
            Console.WriteLine($"Brailee status is {brailee.Status}");

            //brailee.CreditScore = 2000;
            brailee.SetCreditScore(9000);
            brailee.SetCreditScore(90);
            brailee.SetCreditScore(900);
            Console.WriteLine($"Brailee credit score is {brailee.CreditScore}");

            #region morecode
            //brailee.FirstName = "Brailee";
            //brailee.IsPaid = true;
            //brailee.Birthdate = new DateTime(1990, 01, 01);

            //Student jesse = new Student("Jesse", "Kyle");
            //Console.WriteLine($"Jess: {jesse.FirstName} {jesse.LastName}");
            //jesse.SetStatus("past");
            //jesse.IsPaid = true;
            //jesse.Birthdate = new DateTime(1990, 1, 1);

            //Console.WriteLine($"Brailee's Bootcamp is {brailee.Bootcamp}");
            //Console.WriteLine($"Jess's Bootcamp is {jesse.Bootcamp}");
            #endregion
        }
    }
    class Student {
        public int Id { get; set; } // primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Bootcamp { get; set; }
        public string Status { get; set; } // current, future, past
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime Birthdate { get; set; }
        public int CreditScore { get; private set; }

        public void SetCreditScore(int score) {
            if(score >= 400 && score <= 900) {
                this.CreditScore = score;
            } else {
                Console.WriteLine("Credit score must be 400 <= x <= 900.");
            }
        }

        public void SetStatus(string status) {

            if((status == "CURRENT") 
                || (status == "PAST") 
                || (status == "FUTURE")) {
                this.Status = status;
            } else {
                Console.WriteLine("Status must be CURRENT, PAST, or FUTURE");
            }
            
        }

        public Student(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Bootcamp = "Java";
        }
        public Student() {
            this.Bootcamp = ".Net";
        }
    }
}
