using System.CommandLine;
using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.CreateFiles;

static class Router
{
    public static void Add(UserInitalizationArgs Options)
    {
        if(Options.Stock) 
            return;

            Logs.CurrentStep("[RUNNING] Adding Middlewares");
        
        string routerContent = AllFilesText.Router(Options.OnlyJs);

        string directory = Directory.GetCurrentDirectory();
        
        string fileOutName = Options.OnlyJs ? "index.js" : "index.ts";

        

        directory += @$"\{Options.OutputName}\src\routes";
        
        Directory.CreateDirectory(directory);

        

        File.WriteAllText(Path.Combine(directory, fileOutName), routerContent);

        Console.Write($"\n[INFO] Added middleware");
    }
}