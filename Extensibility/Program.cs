using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Temp\\logfile.txt"));
            dbMigrator.Migrate();
            var dbConsMigrator = new DbMigrator(new ConsoleLogger());
            dbConsMigrator.Migrate();
            Console.ReadLine();
        }
    }
}
