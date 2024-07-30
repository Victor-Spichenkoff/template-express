using System.Text;

namespace TemplateExpress.Utils;

class Help
{
    public static Dictionary<string, string> parameters = new Dictionary<string, string>
        {
            { "--congig", "open a menu to manually choose all options" },
            { "--stock", "create the cleanest project (only express + basic app)" },
            { "--js", "use JavaScript" },
            { "--no-prisma", "do not use Prisma" },
            { "--current-dir", "create the project in the current folder" },
            { "-o [output-name]", "change the output folder name (if not set to create in the current folder)" },
            { "--code", "after creation, open the project in vscode" },
            { "--no-middleware", "do not use middlewares (cors, json and router)" }
        };


    public static void Show()
    {
        Console.WriteLine("Parameters:");
        
        DisplayHelp(parameters);
    }

    public static void DisplayHelp(Dictionary<string, string> parameters)
    {
        int maxParamLength = 0;

        // Find the longest parameter name for formatting
        foreach (var param in parameters.Keys)
        {
            if (param.Length > maxParamLength)
            {
                maxParamLength = param.Length + 2;
            }
        }

        // Print each parameter with its description
        foreach (var param in parameters)
        {
            Console.WriteLine($"\n  {param.Key.PadRight(maxParamLength)}  {param.Value}");
        }
    }

}