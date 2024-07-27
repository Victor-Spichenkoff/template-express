using System;
using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.CreateFiles;

static class CreatePackageJson
{
    public static void CreateDefault(UserInitalizationArgs Options, bool dev = false)
    {
        string packageContent = AllFilesText.Package(Options.OnlyJs);

        string directory = Directory.GetCurrentDirectory();
        
        //criar novo projeto
        directory += $@"\{Options.OutputName}";

        //ver se já existe
        if (Directory.Exists(directory) && !dev && !directory.EndsWith("TemplateExpress") && !directory.EndsWith("TemplateExpress\\"))
        {
            if(directory.Contains("Template"))
            Console.WriteLine(directory);
            Console.WriteLine($"[ERROR] The folder \"{Options.OutputName}\" already exists in the current directory");
            bool overwrite = Input.YesOrNo("Overwrite [y/n]: ");
            if(!overwrite) throw new Exception("[ERROR] Unable to create files");

            Directory.Delete(directory, true);
        }


        Directory.CreateDirectory(directory);


        if (Options.OnlyJs)
        {
            File.WriteAllText(Path.Combine(directory, "package.json"), packageContent);
        }


        // RunCommand.Run("npx tsx init");

        

        File.WriteAllText(Path.Combine(directory, "package.json"), packageContent);

        Console.WriteLine("[INFO] Create package.json");
    }
}