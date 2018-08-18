using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class RefTypes
    {

        static void Main(string[] args)
        {
            //User user1 = new User { name = "Tom", age = 22 };
           // ChangeUser(ref user1);//object will change because of reference
           // Console.WriteLine($"{ user1.name} - {user1.age}");

            Person person1 = new Person { name = "Tom", age = 22 };
            ChangePerson(person1);
            Console.WriteLine($"{ person1.name} - {person1.age}");
            Console.ReadKey();

        }
        static void ChangePerson(Person person)
        {
            person.name = "Bob";
            person.age = 33;
        }
        static void ChangeUser(ref User user)
        {
            user.name = "Bob";
            user.age = 33;
        }
    }
    struct User
    {
        public int age;
        public string name;
    }

    class Person
    {
        public int age;
        public string name;
    }
}
