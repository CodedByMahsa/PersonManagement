using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    public class Student: Person
    {
        public string StudentCode {  get; set; }
        public int Grade {  get; set; }

        public override string FullName 
        {
            get { return $"Student: {FirstName} {LastName} ";}
        }

        public override string ToString()
        {
            return $"Student: {FirstName} , {LastName} , {NationalCode} " +
                $", {Grade} , {StudentCode} ";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Student st = (Student)obj;
            return FirstName == st.FirstName &&
            LastName == st.LastName &&
            Grade == st.Grade;

        }

    }
}
