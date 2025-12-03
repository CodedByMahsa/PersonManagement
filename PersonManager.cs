using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    internal class PersonManager
    {
        private static int id = 0;
        private static List<Person> People;
        public PersonManager() 
        {
            if(People==null)
                People=new List<Person>();
        }
        public void RemovePerson(Person person) 
        {
            id = id - 1;
            People.Remove(person);
        }
        public OperationResult Add(Person person) 
        {
            var result = person.Validate();

            if (!result.IsSuccess)
                return result;
            person.ID = id++;
            People.Add(person);
            
            return OperationResult.Success();
        }
        internal IReadOnlyList<Person> GetPeople() 
        {
            ///<summary>
            ///Creates a new list
            ///this way they cant add or remove anything from the list cuz its readonly!
            ///</summary>
            return People;
        }
    }
}
