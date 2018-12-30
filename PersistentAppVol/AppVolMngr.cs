using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PersistentAppVol
{
    public partial class AppVolMngr : ServiceBase
    {
        public AppVolMngr()
        {
            InitializeComponent(); //reminder: don't delete this

        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
