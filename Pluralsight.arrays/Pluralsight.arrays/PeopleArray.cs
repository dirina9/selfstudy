using System;

namespace Pluralsight.arrays
{
    public class PeopleArray
    {
        public void PeopleArrayExample()
        {
            Person[] people = new Person[]
            {
                new Person{Name = "Bill", Age = 7},
                new Person{Name = "Ben", Age = 8}
            };

            foreach (Person person in people)
            {
                person.Age = 20;
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, age={1}", Name, Age);
        }
    }
}