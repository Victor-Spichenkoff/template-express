using Spectre.Console;
using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class Express
{
    public static void Add(bool dev = false)
    {
        Console.WriteLine("\n[RUNNING] Installing express...");
        
        if(dev)
            RunCommand.Run("cd ../tests && npm i --save express");
        
        if(!dev)
            RunCommand.Run("npm i --save express");
        Console.WriteLine("[INFO] Added express");
    }
}