using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composistion
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrater = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());
        }
    }
}
