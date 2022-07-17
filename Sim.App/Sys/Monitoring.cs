using System;
using System.Diagnostics;

namespace Sim.App.Sys
{
    public class Monitoring
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

            privatememory = Process.GetCurrentProcess().PrivateMemorySize64;
            pagedmemory = Process.GetCurrentProcess().PagedMemorySize64;
            physicalmemory = Process.GetCurrentProcess().WorkingSet64;
            
            //usedmemory = privatememory - (physicalmemory - privatememory);

            iApp = string.Format(
                "Processo: {0}" +
                "\nTempo uso CPU: {1} ms" +
                "\n\nPrivate Memory: {2:N0} bytes [{5:N0}MB]" +
                "\nPaged Memory: {3:N0} bytes [{6:N0}MB]" +
                "\nPhysical Memory: {4:N0} bytes [{7:N0}MB]", napp, tapp, privatememory, pagedmemory, physicalmemory, (privatememory / 1000000), (pagedmemory / 1000000), (physicalmemory / 1000000));

            return iApp;
        }

        public string OsInfo()
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
