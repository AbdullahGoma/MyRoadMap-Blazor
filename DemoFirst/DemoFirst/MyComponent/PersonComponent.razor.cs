using DemoFirst.Models;

namespace DemoFirst.MyComponent
{
    public partial class PersonComponent
    {
        // Fields not working
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public List<Person> Persons { get; set; } = new List<Person>();

        public PersonComponent()
        {
            Person = new Person() { Name = "Ahmed", ID = 1 };

            Persons.Add(new Person() { Name = "Abdullah", ID = 2 });
            Persons.Add(new Person() { Name = "Ali", ID = 3 });
            Persons.Add(new Person() { Name = "Mohammed", ID = 4 });
            Persons.Add(new Person() { Name = "Mahmoud", ID = 5 });
            Persons.Add(new Person() { Name = "Khaled", ID = 6 });
        }

        public void GetDetails()
        {
            Person = Persons.FirstOrDefault(P => P.ID == PersonID);
        }
    }
}
