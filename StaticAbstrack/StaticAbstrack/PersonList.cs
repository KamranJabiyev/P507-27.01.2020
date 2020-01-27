using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstrack
{
    class PersonList
    {
        private Person[] arrPerson;

        public PersonList()
        {
            arrPerson = new Person[0];
        }

        public void Append(Person p)
        {
            Array.Resize(ref arrPerson, arrPerson.Length + 1);
            arrPerson[arrPerson.Length - 1] = p;
            Console.WriteLine("Successfully added");
        }

        public void GetAllList()
        {
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item);
            }
        }
    }
}
