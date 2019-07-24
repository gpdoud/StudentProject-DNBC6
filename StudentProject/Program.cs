using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {
            Student brailee = new Student();
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student jesse = new Student();
            jesse.FirstName = "Jess";
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 1, 1);

            string name = jesse.FirstName;
        }
    }
    class Student {
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

        public Student() {
        }
    }
}
