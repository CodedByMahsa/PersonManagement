using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonManagerDGV
{
    public class Person
    {
       // public int ID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string FullName
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
       public virtual OperationResult Validate() 
       {
            if (string.IsNullOrWhiteSpace(FirstName))
                return OperationResult.Failed(Messages.InCorrectName);

            if (string.IsNullOrWhiteSpace(LastName))
                return OperationResult.Failed(Messages.InCorrectLastName);

            if (!NationalCode.CheckNational())
                return OperationResult.Failed(Messages.InCorrectNationalCode);

            if (string.IsNullOrWhiteSpace(GenderText))
                return OperationResult.Failed(Messages.InValidGender);
         
            return OperationResult.Success(Messages.InsertSuccessStudent);
           
       }
       
    }
}


