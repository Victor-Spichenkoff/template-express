using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.CreateFiles;

static class CreateApp
{
    public static void Create(UserInitalizationArgs Options, bool dev = false)
    {
        string indexContent = AllFilesText.App(Options);

        string directory = Directory.GetCurrentDirectory();

        string fileOutName = Options.OnlyJs ? "app.mjs" : "app.ts";

        if (dev)
            directory = @"C:\Users\Pichau\Projects\all_template\final\tests\express";

        if (!Options.CreateOnCurrentDir)
            directory += @$"\{Options.OutputName}\src";
        else
            directory += @"\src";

        Directory.CreateDirectory(directory);

        // if (onlyJs) 
        // {

        // File.WriteAllText(Path.Combine(directory, fileOutName), indexContent);
        // }


        // RunCommand.Run("npx tsx init");



        File.WriteAllText(Path.Combine(directory, fileOutName), indexContent);

        Console.WriteLine($"\n[INFO] Created {fileOutName}");
    }
}