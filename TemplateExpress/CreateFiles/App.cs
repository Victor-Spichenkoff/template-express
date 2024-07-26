using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.CreateFiles;

static class CreateApp
{
    public static void Create(bool onlyJs = false, string outputDir = "", bool dev = false)
    {
        string indexContent = AllFilesText.App;

        string directory = string.IsNullOrEmpty(outputDir) ? Directory.GetCurrentDirectory() : outputDir;
        
        string fileOutName = onlyJs ? "app.js" : "app.ts";

        if(dev)
            directory = @"C:\Users\Pichau\Projects\all_template\final\tests";

        directory += @"\src";
        Directory.CreateDirectory(directory);

        // if (onlyJs) 
        // {

            // File.WriteAllText(Path.Combine(directory, fileOutName), indexContent);
        // }


        // RunCommand.Run("npx tsx init");

        

        File.WriteAllText(Path.Combine(directory, fileOutName), indexContent);

        Console.WriteLine($"[INFO] Create {fileOutName}");
    }
}