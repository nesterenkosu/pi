using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace NHibernateMultitable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание таблицы БД на основе
            //файлов ORM-отображения (маппинга)
            var cfg = new Configuration();
            //Считывание и обработка файла hibernate.cfg.xml
            cfg.Configure();
            //Привязка к сборке, содержащей объекты ORM
            cfg.AddAssembly("NHibernateMultitable");
            //Собственно создание таблиц
            new SchemaExport(cfg).Execute(true, true, false);

            //Для выполнения действий над данными
            //нужно открыть сессию
            ISession session = cfg.BuildSessionFactory().OpenSession();


            var cpp = new Language { Name = "C++" };
            session.Save(cpp);
            session.Flush();
            var php = new Language { Name = "PHP" };
            session.Save(php);
            session.Flush();
            var js = new Language { Name = "JS" };
            session.Save(js);
            session.Flush();

            var Andrew = new Employee { 
                Name = "Андрей",
                Email ="andrew@mail.ru",
                Age = 30,
                Educations = new List<Education>(),
                Languages = new List<Language> { cpp,php,js}
            };

            //var susu = new Education { Name = "SUSU", Year = 2000, employee = Andrew };
            Andrew.Educations.Add(new Education { Name = "ЮУрГУ", Year = 2000, employee = Andrew });
            Andrew.Educations.Add(new Education() { Name = "ЧелГУ", Year = 2020, employee = Andrew });

            session.Save(Andrew);
            session.Flush();

            Console.ReadLine();
        }
    }
}
