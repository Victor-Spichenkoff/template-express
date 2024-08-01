using System.CommandLine;
using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.CreateFiles;

static class Middlewares
{
    public static void Add(UserInitalizationArgs Options)
    {
        if (Options.Stock || Options.NoMiddlewares)
            return;

        Logs.CurrentStep("Middlewares");
        Console.WriteLine("[RUNNING] Adding Middlewares");

        string routerContent = AllFilesText.Router(Options.OnlyJs);

        string directory = Directory.GetCurrentDirectory();

        string fileOutName = Options.OnlyJs ? "index.mjs" : "index.ts";

        if (!Options.CreateOnCurrentDir)
            directory += @$"\{Options.OutputName}\src\routes";
        else
            directory += @$"\src\routes";

        Directory.CreateDirectory(directory);


        //baixando depencias dos middlwares
        string downloadTypes = Options.OnlyJs ? "" : "&& npm i --save-dev @types/cors";
        RunCommand.OpenFolderAndRun($"npm i --save cors {downloadTypes}", Options);
        File.WriteAllText(Path.Combine(directory, fileOutName), routerContent);

        Console.WriteLine($"[INFO] Added middlewares");
    }
}