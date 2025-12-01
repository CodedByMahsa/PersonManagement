using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    public class OperationResult
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }

        public static OperationResult Failed(string message) =>
            new OperationResult { IsSuccess = false, Message = message };

        public static OperationResult Success() =>
            new OperationResult { IsSuccess = true };

        public static OperationResult ValidateInput(Person? person)
        {
            if (person is null)
                return Failed("Person cannot be null.");

            if (string.IsNullOrWhiteSpace(person.FirstName))
                return Failed("نام خود را درست وارد کنید !");

            if (string.IsNullOrWhiteSpace(person.LastName))
                return Failed("نام خانوادگی خود را درست وارد کنید !");

            if (string.IsNullOrWhiteSpace(person.GenderText))
                return Failed("جنسیت خود را درست وارد کنید !");

            if (string.IsNullOrWhiteSpace(person.NationalCode))
                return Failed("کد ملی وارد نشده است !");

            // CheckNational returns bool
            if (!person.NationalCode.CheckNational())
                return Failed("کد ملی خود را درست وارد کنید !");

            return Success();
        }
        
    }
    
    /* public class OperationResult
     {
         public bool IsSuccess {  get; set; }
         public string Message {  get; set; }

         public static OperationResult Failed (string message)
         {
             return new OperationResult
             {
                 IsSuccess = false,
                 Message = message
             };
         }
         public static OperationResult Success() 
         {
             return new OperationResult
             {
                 IsSuccess = true
             };
         }
         public OperationResult ValidateInput(Person person)
         {
             //OperationResult operation=new OperationResult();
             bool invalidFName = string.IsNullOrEmpty(person.FirstName);
             bool invalidLName = string.IsNullOrEmpty(person.LastName);
             var invalidNationalCode = person.NationalCode.CheckNational();
             bool invalidGender = string.IsNullOrEmpty(person.GenderText);

             if (invalidFName == true)
             {
                 return OperationResult.Failed("نام خود را درست وارد کنید !");
             }
             if (invalidLName == true)
             {
                 return OperationResult.Failed("نام خانوادگی خود را درست وارد کنید !");
             }
             if (IsSuccess)
             {
                 return OperationResult.Failed(Message);
             }
             if (invalidGender == true)
             {
                 return OperationResult.Failed("جنسیت خود را درست وارد کنید !");
             }
             return OperationResult.Success();
         }
     }*/
}
