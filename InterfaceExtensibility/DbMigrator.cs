using System;

namespace InterfaceExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Db migration started {DateTime.Now}");

            _logger.LogInfo($"Db migration finished {DateTime.Now}");
        }
    }
}
