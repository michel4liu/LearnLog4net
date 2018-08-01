using log4net;
using log4net.Repository;
using System;
using System.IO;
using System.Threading;

namespace LearnLog4net
{
    class Program
    {

        private static ILog log = LogManager.GetLogger(typeof(Program));
        private static ILoggerRepository _loggerRepository;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            _loggerRepository = LogManager.CreateRepository(
                                typeof(Program).Assembly,
                                typeof(log4net.Repository.Hierarchy.Hierarchy));

            log4net.Config.XmlConfigurator.Configure(_loggerRepository, File.OpenRead("log4net.config"));


            log.Info("Entering application.");

            Console.ReadLine();
        }
    }
}
