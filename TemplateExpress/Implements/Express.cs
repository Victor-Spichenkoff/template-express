using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class Express
{
    public static void Add(UserInitalizationArgs Options, bool dev = false)
    {
        Logs.CurrentStep("downloading EXPRESS");
        Console.Write("[RUNNING] Installing express...");
        
        
        if(dev)
            RunCommand.Run($"cd ../tests && npm i --save express");
            
        if(!dev)
            RunCommand.OpenFolderAndRun("npm install --save express && npm install -D nodemon", Options);
            // RunCommand.OpenFolderAndRun("", Options);


        Console.Write("[INFO] Added express");
    }
}