using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogSample
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 1000; i++ )
                {
                    logger.Info(i);
                    logger.Info("info message");
                    logger.Debug("debug message");
                }
                
                throw new Exception("test excpetion log");
            }
            catch (Exception e)
            {

                logger.Error(e, "excpetion log ");
            }
            
        }
    }
}
