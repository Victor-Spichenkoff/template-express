using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class Express
{
    public static void Add(UserInitalizationArgs Options, bool dev = false)
    {
        Console.WriteLine("\n[RUNNING] Installing express...");
        
        
        if(dev)
            RunCommand.Run($"cd ../tests && npm i --save express");
            
        if(!dev)
            RunCommand.OpenFolderAndRun("npm i --save express", Options);


        Console.WriteLine("[INFO] Added express");
    }
}