using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    internal class StudentManager
    {
        private static List<Student> students ;
        public StudentManager()
        {
            if (students == null)
                students = new List<Student>();
        }
        public OperationResult Add(Student student)
        {
            var result = student.Validate();
            if (!result.IsSuccess)
                return result;

            if (students.Any(s => s.NationalCode == student.NationalCode))
                return OperationResult.Failed(Messages.DuplicateNationalCode);

            if (students.Any(s => s.StudentCode == student.StudentCode))
                return OperationResult.Failed(Messages.DuplicateStudentCode);
          
            students.Add(student);
            
            return OperationResult.Success(Messages.InsertSuccessStudent);
        }
        public OperationResult Edit(Student student)
        {
            var result = student.Validate();
            if (!result.IsSuccess)
                return result;

            if (students.Any(s => s.NationalCode == student.NationalCode))
                return OperationResult.Failed(Messages.DuplicateNationalCode);

            if (students.Any(s => s.StudentCode == student.StudentCode))
                return OperationResult.Failed(Messages.DuplicateStudentCode);

            students.Add(student);
            return OperationResult.Success(Messages.EditSuccessStudent);

        }
        public void Remove(Student student)
        {
            students.Remove(student);
        }
        internal IReadOnlyList<Student> GetAll()
        {
            ///<summary>
            ///Creates a new list
            ///this way they cant add or remove anything from the list cuz its readonly!
            ///</summary>
            return students;
        }
    }
}
