using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    public class OperationResult
    {
        protected OperationResult(bool isSuccess , string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }

        public static OperationResult Failed (string message)
        { 
            return new OperationResult(false, message);
        }
        public static OperationResult Success (string message)
        {
            return new OperationResult(true, message);
        }
        //  public static OperationResult Failed(string message) =>
        // new OperationResult { IsSuccess = false, Message = message };

        //public static OperationResult Success() =>
           // new OperationResult { IsSuccess = true };

    }
    public class OperationResult<T> : OperationResult
    {
        public T Data { get; set; }
        private OperationResult(bool isSuccess, string message, T data) : base(isSuccess, message)
        {
            Data = data;
        }
        public static OperationResult<T> Failed(string message)
        {
            return new OperationResult<T>(false, message, default);
        }
        public static OperationResult<T> Success (string message , T data)
        {
            return new OperationResult<T> (true, message, data);
        }
          

       

    }
}
