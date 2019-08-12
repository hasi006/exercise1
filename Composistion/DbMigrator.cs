namespace Composistion
{
    public class DbMigrator
    {
        private readonly Logger log;

        public DbMigrator(Logger log)
        {
            this.log = log;
        }

        public void Migrate()
        {
            log.Log("Db Migarting");
        }
    }
}
