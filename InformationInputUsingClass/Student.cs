using System;

namespace InformationInputUsingClass
{
    class Student
    {
        public Student(string fName,string lName,DateTime dob) {
            FirstName = fName;
            LastName = lName;
            DOB = dob;
        }
        public string FirstName;
        public string LastName;
        public DateTime DOB;

        public string GetInfo()
        {
            return "First Name: "+FirstName
                +"\nLast Name: "+LastName
                +"\nDOB:"+DOB+"\n\n";
        }
    }

}
