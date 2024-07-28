using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class TypeScript
{
    public static void Add(UserInitalizationArgs Options, bool dev = false)
    {
        if(Options.OnlyJs) return;
        Logs.CurrentStep("DOWNLOADING TypeScript");
        
        Console.WriteLine("\n[RUNNING] Starting TypeScript...");

        RunCommand.OpenFolderAndRun("npm i typescript ts-node @types/node @types/express --save-dev", Options);

        Console.WriteLine("[INFO] Added TypeScript");
    }
}