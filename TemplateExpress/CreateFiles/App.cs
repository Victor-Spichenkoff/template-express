using TemplateExpress.Text;
using TemplateExpress.Utils;

namespace TemplateExpress.CreateFiles;

static class CreateApp
{
    public static string outputDir = "";
    public static void Create(bool onlyJs = false, bool dev=false)
    {
        if (onlyJs) return;


        string directory = string.IsNullOrEmpty(outputDir) ? Directory.GetCurrentDirectory() : outputDir;
        if(dev)
         directory =  "../../tests/";
        

            Console.WriteLine("Automatizando a criação de API Express em Node.js...");

            // RunCommand.Run("npx tsx init");

            string indexContent = AllFilesText.App;

            File.WriteAllText(Path.Combine(directory, "index.ts"), indexContent);

            Console.WriteLine("API Express criada com sucesso!");
    }
}