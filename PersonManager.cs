using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    internal class PersonManager
    {
        private static List<Person> People;
        public PersonManager() 
        {
            if(People==null)
                People=new List<Person>();
        }
        
        public void RemovePerson(Person person) 
        {
            People.Remove(person);
        }
        internal void Add(Person person) 
        {
            People.Add(person);
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
