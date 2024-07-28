using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class TypeScript
{
    public static void Add(UserInitalizationArgs Options, bool dev = false)
    {
        if(Options.OnlyJs) return;
        Logs.CurrentStep("DOWNLOADING TypeScript");
        
        Console.Write("[RUNNING] Starting TypeScript...");

        RunCommand.OpenFolderAndRun("npm i typescript ts-node @types/node @types/express --save-dev && npx tsc --init", Options);

        Console.Write("[INFO] Added TypeScript");
    }
}