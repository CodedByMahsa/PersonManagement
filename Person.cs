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
        public int ID { get; set; } = 0;
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
       /* public OperationResult ValidateInput()
        {
            bool invalidFName = string.IsNullOrEmpty(FirstName);
            bool invalidLName = string.IsNullOrEmpty(LastName);
            var invalidNationalCode = NationalCode.CheckNational();
            bool invalidGender = string.IsNullOrEmpty(GenderText);

            if (invalidFName==true)
            {
                return OperationResult.Failed("نام خود را درست وارد کنید !");
            }
            if (invalidLName == true)
            {
                return OperationResult.Failed("نام خانوادگی خود را درست وارد کنید !");
            }
            if (!invalidNationalCode.Success()) 
            {
                
            }
            if (invalidGender == true)
            {
                return OperationResult.Failed("جنسیت خود را درست وارد کنید !");
            }
            return OperationResult.Success();
        }*/
    }
    public static class NationaleExtention
    {
        public static bool CheckNational(this string NationalCode)
        {
            bool valid = true;
            try
            {
                char[] chArray = NationalCode.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                int num2 = numArray[9];
                switch (NationalCode)
                {
                    case "0000000000":
                    case "1111111111":
                    case "22222222222":
                    case "33333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":
                        valid = false;
                        break;
                }
                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8))
                + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4))
                + (numArray[7] * 3)) + (numArray[8] * 2);

                int num4 = num3 - ((num3 / 11) * 11);

                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) ||
                    ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {
                    //"National Code is Valid"
                }
                else
                {
                    valid = false;
                }
            }
            catch
            { valid = false; }
            return valid;
        }
    }

}


