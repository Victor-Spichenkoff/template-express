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


        //arrumnar os arquivos:
        string directorySchema = Directory.GetCurrentDirectory();
        
        directorySchema += @$"\{Options.OutputName}\prisma";
        
        Directory.CreateDirectory(directorySchema);

        string schemaContent = AllFilesText.SchemaDotPrisma;

        File.WriteAllText(Path.Combine(directorySchema, "schema.prisma"), schemaContent);
        
        
        string directoryEnv = Directory.GetCurrentDirectory();
        
        directoryEnv += @$"\{Options.OutputName}";

        string envContent = AllFilesText.DotEnv;

        File.WriteAllText(Path.Combine(directoryEnv, ".env"), envContent);




        Console.WriteLine("[INFO] Updated Prisma configurations");


        //prisma client
        string prismaClientContent = AllFilesText.PrismaClient(Options.OnlyJs);

        string directory = Directory.GetCurrentDirectory();
        directory += $"\\{Options.OutputName}\\src\\lib";
        
        Directory.CreateDirectory(directory);

        string fileExtension = Options.OnlyJs ? "mjs" : "ts";
        File.WriteAllText(Path.Combine(directory, $"db.{fileExtension}"), prismaClientContent);

        Console.WriteLine("[INFO] Added Prisma Client");

        //adicionar o client
        RunCommand.OpenFolderAndRun("npx prisma generate", Options);

        Console.Write("[INFO] Added Prisma");
    }
}