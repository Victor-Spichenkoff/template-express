using System;
using System.Diagnostics;
using System.IO;

namespace TemplateExpress.Utils;

public class RunCommand
{
    public static void Run(string command)
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
            Console.WriteLine(process.StandardOutput.ReadLine());
        }
        process.WaitForExit();
    }

}