using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace JobScheduler
{
    public partial class JobSchedulerService : ServiceBase
    {
        public static Logger logger = LogManager.GetLogger("JobSchedulerService");

        public JobSchedulerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string processFilename = System.Configuration.ConfigurationManager.AppSettings["PathToRun"];
            string tickSeconds = System.Configuration.ConfigurationManager.AppSettings["TickSeconds"];
            int tickSecondsInt;
            if (!int.TryParse(tickSeconds, out tickSecondsInt))
            {
                logger.Error("Could not parse tickSeconds configuration as a number: " + tickSeconds);
            }
            else
            {
                tickTimer.Interval = tickSecondsInt * 1000;
                logger.Info("Setting the tick interval to " + tickSecondsInt.ToString());
            }
            //int.Parse(tickSeconds)
            
            logger.Info("The process filename is " + processFilename);
            
            process1.StartInfo.FileName = processFilename;
            tickTimer.Start();

            logger.Info("Scheduler service started");
        }

        protected override void OnStop()
        {
            tickTimer.Stop();

            logger.Info("Scheduler service stopped");
        }

        private void tickTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            logger.Info("Timer tick occurred");
            try
            {
                process1.Start();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
