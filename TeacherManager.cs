using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    internal class TeacherManager
    {
        private static List<Teacher> teachers;
        public TeacherManager()
        {
            if (teachers == null)
                teachers = new List<Teacher>();
        }

        public OperationResult Add(Teacher teacher)
        {
            var result = teacher.Validate();
            if (!result.IsSuccess)
                return result;
            //students.ID = id++;
            teachers.Add(teacher);

            return OperationResult.Success();
        }
        public void Edit(Teacher teacher)
        {

        }
        public void Remove(Teacher teacher)
        {
            //id = id - 1;
            teachers.Remove(teacher);
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
