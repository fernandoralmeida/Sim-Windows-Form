using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Classes
{
    public class AppMonitoring
    {
      
        string napp, iApp;
        double tapp;
        long allmemory, survivedmemory, privatememory, pagedmemory, physicalmemory;

        public string AppInfo()
        {
          
            napp = AppDomain.CurrentDomain.FriendlyName;
            tapp = AppDomain.CurrentDomain.MonitoringTotalProcessorTime.TotalMilliseconds;
            allmemory = AppDomain.CurrentDomain.MonitoringTotalAllocatedMemorySize;
            survivedmemory = AppDomain.CurrentDomain.MonitoringSurvivedMemorySize;
            
            privatememory = System.Diagnostics.Process.GetCurrentProcess().PrivateMemorySize64;
            pagedmemory = System.Diagnostics.Process.GetCurrentProcess().PagedMemorySize64;
            physicalmemory = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;
            //usedmemory = privatememory - (physicalmemory - privatememory);

            iApp = string.Format(
                "Processo: {0}" +
                "\nTempo uso CPU: {1} ms" +
                "\n\nPrivate Memory: {2:N0} bytes [{5:N0}MB]" +
                "\nPaged Memory: {3:N0} bytes [{6:N0}MB]" +
                "\nPhysical Memory: {4:N0} bytes [{7:N0}MB]", napp, tapp, privatememory, pagedmemory, physicalmemory, (privatememory / 1000000), (pagedmemory / 1000000), (physicalmemory / 1000000));

            return iApp;
        }

        public string PcOsInfo()
        {
            string OS = string.Empty;

            OperatingSystem OsEnv = Environment.OSVersion;

            if (Environment.Is64BitOperatingSystem == true)
                OS = OsEnv.VersionString.ToString() + " 64Bits " + OsEnv.ServicePack.ToString() + Environment.NewLine;
            else
                OS = OsEnv.VersionString.ToString() + " 32Bits " + OsEnv.ServicePack.ToString() + Environment.NewLine;

            return OS;
        }
    }
}
