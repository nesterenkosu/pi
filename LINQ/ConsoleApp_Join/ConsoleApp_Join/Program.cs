using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Join
{
    class Program
    {
        class Employee
        {
            public string name { get; set; }
            public string language { get; set; }
        }

        class Language
        {
            public string name { get; set; }
            public bool is_compiled { get; set; }
        }
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {name="Vasiliy",language="C"},
                new Employee {name="Nikolay",language="PHP"},
                new Employee {name="Petr",language="C"},
            };

            List<Language> languages = new List<Language>()
            {
                new Language {name="C",is_compiled=true},
                new Language {name="PHP",is_compiled=false},
                new Language {name="JavaScript",is_compiled=false},
            };

            /*var result = from employee in employees
                         join language in languages on employee.language equals language.name
                         select new {
                             name = employee.name,
                             language = employee.language,
                             is_compiled = language.is_compiled
                         };

            foreach (var item in result)
                Console.WriteLine(item.name+" "+item.language+" "+item.is_compiled.ToString());*/

            var result2 = languages.GroupJoin(
                employees,
                l => l.name,
                e => e.language,
                (language,employee) => new
                {
                    Name = language.name,
                    IsCompiled = language.is_compiled.ToString(),
                    Employees = employee.Select(emp=>emp.name)
                });

            foreach (var item in result2) {
                Console.WriteLine("Язык:"+item.Name+" Компилируемый:"+item.IsCompiled);
                Console.WriteLine("============================");
                foreach (var employee in item.Employees)
                    Console.WriteLine(employee);
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
