 using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("-----------------------------------------------------------------------------------------------------------------------");
            _logger.LogInfo("Migrating started at " + DateTime.Now );
            //Console.WriteLine("Migrating started at {0}", DateTime.Now);
            //
            //Console.WriteLine("Migrating finished at {0}", DateTime.Now);
            _logger.LogInfo("Migrating finished at " + DateTime.Now);
            _logger.LogError(DateTime.Now + " Oh, ow...." );
            _logger.LogInfo("***********************************************************************************************************************");

        }
    }
}