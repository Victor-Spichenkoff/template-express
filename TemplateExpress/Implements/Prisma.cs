using System.CommandLine;
using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class Prisma
{
    public static void Add(UserInitalizationArgs Options, bool dev = false)
    {
        if(Options.NoPrisma || Options.Stock) return;
        Logs.CurrentStep("IMPLEMENTING Prisma");
        
        Console.Write("[RUNNING] Downloading Prisma...");

        RunCommand.OpenFolderAndRun("npm install prisma -D && npm install @prisma/client --save", Options);

        Console.WriteLine("[RUNNING] Setting Up Prisma");
        RunCommand.OpenFolderAndRun("npx prisma init", Options);



        //adicionar o client
        RunCommand.OpenFolderAndRun("npx prisma generate", Options);
        
        
        string prismaClientContent = AllFilesText.PrismaClient(Options.OnlyJs);

        string directory = Directory.GetCurrentDirectory();
        directory += $"\\{Options.OutputName}\\src\\lib";
        
        Directory.CreateDirectory(directory);

        string fileExtension = Options.OnlyJs ? "js" : "ts";
        File.WriteAllText(Path.Combine(directory, $"db.{fileExtension}"), prismaClientContent);

        Console.WriteLine("[INFO] Added Prisma Client");

        Console.Write("[INFO] Added Prisma");
    }
}