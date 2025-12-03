using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonManagerDGV
{
    public class Person
    {
        public int ID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public string NationalCode { get; set; }
        public Genders Gender { get; set; }
        public string GenderText
        {
            get
            {
                switch (Gender)
                {
                    case Genders.Male:
                        return "مرد";
                    case Genders.Female:
                        return "زن";
                    default:
                        return "نامشخص";
                }
            }
        }
       public OperationResult Validate() 
       {
            if (string.IsNullOrWhiteSpace(FirstName))
                return OperationResult.Failed("نام خود را درست وارد کنید!");

            if (string.IsNullOrWhiteSpace(LastName))
                return OperationResult.Failed("نام خانوادگی خود را درست وارد کنید!");

            if (!NationalCode.CheckNational())
                return OperationResult.Failed("کد ملی معتبر نیست!");

            if (string.IsNullOrWhiteSpace(GenderText))
                return OperationResult.Failed("جنسیت معتبر نیست!");
         
            return OperationResult.Success();
           
       }
    }
}


