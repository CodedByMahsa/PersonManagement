using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    public class TeacherManager
    {
        private static List<Teacher> teachers;

        public TeacherManager()
        {
            if (teachers == null)
                teachers = new List<Teacher>();
        }
       
        public OperationResult Add(Teacher teacher)
        {
            //if(String.IsNullOrWhiteSpace(teacher.FirstName))
            ///Here you are trying to add a teacher just like studentManager 
            var result = teacher.Validate();
            if (!result.IsSuccess)
                return result;

            if (teachers.Any(s => s.NationalCode == teacher.NationalCode))
                return OperationResult.Failed(Messages.DuplicateNationalCode);

            if (teachers.Any(s => s.Major == teacher.Major))
                return OperationResult.Failed(Messages.DuplicateStudentCode);
            
                teachers.Add(teacher);

            return OperationResult.Success(Messages.InsertSuccessStudent);
           
        }
        public void Edit(Teacher teacher)
        {
            //object is already modified by reference
            //OnTeachersChanged();
        }
        public void Remove(Teacher teacher)
        {
            teachers.Remove(teacher);
           // OnTeachersChanged();
        }
        internal IReadOnlyList<Teacher> GetAll()
        {
            ///<summary>
            ///Creates a new list
            ///this way they cant add or remove anything from the list cuz its readonly!
            ///</summary>
            return teachers;
        }
    }
}
