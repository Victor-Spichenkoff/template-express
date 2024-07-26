using System;
using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.CreateFiles;

static class CreatePackageJson
{
    public static void CreateDefault(bool onlyJs = false,bool dev = false)
    {
        string packageContent = AllFilesText.Package(onlyJs);

        string directory = Directory.GetCurrentDirectory();
        
        if(dev)
            directory = @"C:\Users\Pichau\Projects\all_template\final\tests";


        if (onlyJs) 
        {
            File.WriteAllText(Path.Combine(directory, "package.json"), packageContent);
        }


        // RunCommand.Run("npx tsx init");

        

        File.WriteAllText(Path.Combine(directory, "package.json"), packageContent);

        Console.WriteLine("[INFO] Create package.json");
    }
}