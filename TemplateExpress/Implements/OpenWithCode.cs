using System.CommandLine;
using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class VSCode
{
    public static void Add(UserInitalizationArgs Options)
    {
        if(!Options.OpenWithCode) return;
        
        Logs.CurrentStep("Opening...");
        
        RunCommand.OpenFolderAndRun("code .", Options);
        Console.Write("[INFO] Open");
    }
}