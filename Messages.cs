using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    public static class Messages
    {
        public static string InCorrectName
        {
            get { return "نام خود را درست وارد کنید!"; }
        }
        public static string InCorrectLastName
        {
            get { return "نام خانوادگی خود را درست وارد کنید!"; }
        }
        public static string InValidGender
        {
            get { return "جنسیت معتبر نیست!"; }
        }
        public static string DuplicateNationalCode
        {
            get{ return "کد ملی تکراری است!"; }
        }
        public static string InCorrectNationalCode
        {
            get { return "کد ملی معتبر نیست!"; }
        }
        public static string InValidPhoneNumber
        {
            get { return "شماره تلفن را درست وارد کنید !"; }
        }
        public static string InvalidAddress
        {
            get { return "آدرس را درست وارد کنید !"; }
        }
        public static string InvalidMajor
        {
            get { return "رشته را درست وارد کنید !"; }
        }
        public static string DuplicateTeacher
        {
            get { return "استاد ها یکسان هستند !"; }
        }
        public static string DuplicateStudentCode
        {
            get{ return "کد دانش آموزی تکراری است!"; }
        }
        public static string InsertSuccessStudent
        {
            get{ return "دانشجو با موفقیت ثبت شد"; }
        }
        public static string EditSuccessStudent
        {
            get{ return "دانشجو با موفقیت ویراش شد"; }
        }
        public static string EditSuccessTeacher
        {
            get { return "استاد با موفقیت ویراش شد"; }
        }
        public static string InsertSuccessTeacher
        {
            get{ return "استاد با موفقیت ویراش شد"; }
        }
    }
}
