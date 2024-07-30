using System.CommandLine;
using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class Express
{
    public static void Add(UserInitalizationArgs Options)
    {
        Logs.CurrentStep("downloading EXPRESS");
        Console.Write("[RUNNING] Installing express...");
        

            RunCommand.OpenFolderAndRun("npm install --save express && npm install -D nodemon", Options);
            if(!Options.NoMiddlewares && !Options.Stock)
                RunCommand.OpenFolderAndRun("npm i --save cors", Options);  


        Console.Write("[INFO] Added express");
    }
}