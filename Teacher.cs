using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    public class Teacher : Person
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Major { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                Teacher teacher = (Teacher)obj;
                if (teacher.PhoneNumber == PhoneNumber &&
                teacher.NationalCode == NationalCode)
                {
                    MessageBox.Show(Messages.DuplicateTeacher);
                    return true;
                }
                else return false;
            }
        }
        
        public override OperationResult Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                return OperationResult.Failed(Messages.InCorrectName);

            if (string.IsNullOrWhiteSpace(LastName))
                return OperationResult.Failed(Messages.InCorrectLastName);

            if (!NationalCode.CheckNational())
                return OperationResult.Failed(Messages.InCorrectNationalCode);
            
            if (string.IsNullOrWhiteSpace(PhoneNumber))
                return OperationResult.Failed(Messages.InValidPhoneNumber);
            
            if (string.IsNullOrWhiteSpace(Address))
                return OperationResult.Failed(Messages.InvalidAddress);

            if (string.IsNullOrWhiteSpace(Major))
                return OperationResult.Failed(Messages.InvalidMajor);

            if (string.IsNullOrWhiteSpace(GenderText))
                return OperationResult.Failed(Messages.InValidGender);

            return OperationResult.Success(Messages.InsertSuccessTeacher);
        }
    }
   

}
