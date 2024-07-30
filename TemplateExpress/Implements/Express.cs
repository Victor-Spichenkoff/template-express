using System.CommandLine;
using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class Express
{
    public static void Add(UserInitalizationArgs Options)
    {
        Logs.CurrentStep("downloading EXPRESS");
        Console.Write("[RUNNING] Installing express...");
        
        RunCommand.OpenFolderAndRun($"npm install --save express && npm install -D nodemon", Options);  

        Console.Write("[INFO] Added express");
    }
}