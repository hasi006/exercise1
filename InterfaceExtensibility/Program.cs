using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtensibility
{


    class Program
    {
        static void Main(string[] args)
        {
            //var migrator = new DbMigrator(new ConsoleLogger());
            var migrator = new DbMigrator(new FileLogger("test.txt"));
            migrator.Migrate();
        }
    }
}
