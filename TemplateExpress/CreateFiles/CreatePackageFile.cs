using System;
using System.CommandLine;
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
        if (!Options.CreateOnCurrentDir)
            directory += $@"\{Options.OutputName}";

        //ver se já existe
        if (Directory.Exists(directory) && !dev && !directory.EndsWith("TemplateExpress") && !directory.EndsWith("TemplateExpress\\") && !Options.CreateOnCurrentDir)
        {
            if (directory.Contains("Template"))
                Console.WriteLine($"[ERROR] The folder \"{Options.OutputName}\" already exists in the current directory");
            bool overwrite = Input.YesOrNo("Overwrite [y/n]: ");
            if (!overwrite) throw new Exception("[ERROR] Unable to create files");

            Directory.Delete(directory, true);
        }

        if (!Options.CreateOnCurrentDir)
            Directory.CreateDirectory(directory);


        Logs.CurrentStep("Starting project");

        if (Options.OnlyJs)
        {
            File.WriteAllText(Path.Combine(directory, "package.json"), packageContent);
        }


        File.WriteAllText(Path.Combine(directory, "package.json"), packageContent);

        Console.WriteLine("[INFO] Created package.json");
    }
}