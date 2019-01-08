using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCompact
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext dbc=new MyDbContext())
            {
                PersonEntity person = new PersonEntity();
                person.Name = "aa";
                dbc.Persons.Add(person);
                dbc.SaveChanges();
                Console.WriteLine(person.Id);
            }
            Console.ReadKey();
        }
    }
}
