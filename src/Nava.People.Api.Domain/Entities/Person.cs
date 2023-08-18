using Nava.People.Api.Domain.Validations;


namespace Nava.People.Api.Domain.Entities
{
    public sealed class Person
    {
        // Fields
        private string firstName;
        private string lastName;
        private string document;
        private int age;
        private string address;
        private string phoneNumber;

        // Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Document
        {
            get { return document; }
            set { document = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // Constructors
        public Person()
        {
            // Default constructor
        }

        public Person(string firstName, string lastName,string document, int age, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;

        }

        // Methods

        public void DisplayContactInfo()
        {
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }

}

