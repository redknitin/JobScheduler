namespace JobScheduler
{
    partial class JobSchedulerService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.process1 = new System.Diagnostics.Process();
            this.tickTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.tickTimer)).BeginInit();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.tickTimer_Elapsed);
            // 
            // JobSchedulerService
            // 
            this.ServiceName = "JobScheduler";
            ((System.ComponentModel.ISupportInitialize)(this.tickTimer)).EndInit();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Timers.Timer tickTimer;
    }
}
