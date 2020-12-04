using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public string Name { get; set;}
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User { Name ="Vasya", Age=30 });
            users.Add(new User { Name = "Kolya", Age = 40 });

            var selected_users = from user in users
                                 select new
                                 {
                                     FirstName = user.Name,
                                     DateOfBirth = DateTime.Now.Year - user.Age
                                 };

            foreach (var selected_user in selected_users)
                Console.WriteLine(selected_user.FirstName+" "+selected_user.DateOfBirth);

            Console.ReadKey();
        }
    }
}
