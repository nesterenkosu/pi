using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ConsoleApp3_Linq2DB
{
    [Table(Name = "dbo.Table")]
    public class TableBox
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Language")]
        public string Language { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lect\20201204_PI_LINQ\ConsoleApp3_Linq2DB\ConsoleApp3_Linq2DB\Database1.mdf;Integrated Security=True");

            TableBox user1 = new TableBox { Name = "Vitaliy", Language = "C" };
            // добавляем его в таблицу Users
            db.GetTable<TableBox>().InsertOnSubmit(user1);
            db.SubmitChanges();

            var users = from u in db.GetTable<TableBox>()
            where u.Name.StartsWith("V")
            orderby u.Language
            select u;

            foreach (var user in users)
                Console.WriteLine(user.Id+" "+user.Name+" "+user.Language);

            Console.ReadLine();
        }
    }
}
