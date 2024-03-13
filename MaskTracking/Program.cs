
using Business.Concrete;
using Entities.Concrete;

namespace MaskTracking
{ class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.FirstName = "A";
            person.LastName = "B";
            person.NationalId = 123;
            person.BirthYear = 1998;



            PttManager pttManager = new PttManager(new PersonMenager());
            pttManager.GiveMask(person);
        }

  

    }

    class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long NationalId { get; set; }

    }
}