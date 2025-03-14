using System;
using System.Diagnostics;
using System.IO;

namespace TemplateExpress.Utils;

public class RunCommand
{
    public static void Run(string command, bool fullLogs = false)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C {command}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };
        process.Start();
        while (!process.StandardOutput.EndOfStream)
        {
            if (fullLogs)
                Console.WriteLine(process.StandardOutput.ReadLine());

            if (!fullLogs)
                process.StandardOutput.Read();
        }
        process.WaitForExit();
    }


    public static void OpenFolderAndRun(string command, UserInitalizationArgs Options)
    {
        Console.WriteLine("");
        if (Options.CreateOnCurrentDir)
        {
            Run(command);
        }
        else
        {
            Run($"cd ./{Options.OutputName} && {command}");
        }
    }
}