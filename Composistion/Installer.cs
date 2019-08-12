using System;

namespace Composistion
{
    public class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            Console.WriteLine("Installing");
        }
    }
}
