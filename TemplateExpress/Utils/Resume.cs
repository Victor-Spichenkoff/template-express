namespace TemplateExpress.Utils;

class Resume
{
    public static bool ShowAndAsk(UserInitalizationArgs Options)
    {
        Dictionary<string, string> parameters = new Dictionary<string, string>
        {
            { "Create on current directory", FormatResumeRightSide(Options.CreateOnCurrentDir) },
            { "Output Folder Name", Options.OutputName == "" ? "Current Directory" : Options.OutputName },
            { "Use TypeScript", FormatResumeRightSide(!Options.OnlyJs) },
            // { "Create Stock Project", FormatResumeRightSide(Options.Stock) },
            { "Use Prisma",     FormatResumeRightSide(!Options.NoPrisma) },
            { "Use Middlewares", FormatResumeRightSide(!Options.NoMiddlewares) },
            { "Open with VSCode", FormatResumeRightSide(Options.OpenWithCode) },
        };

        FormatResumeItem(parameters);
        return Input.YesOrNo("Contine [y/n]: ");
        
    }



    public static void FormatResumeItem(Dictionary<string, string> parameters)
    {
        Logs.CurrentStep("Resume");
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
            Console.WriteLine($"{param.Key.PadRight(maxParamLength)}  {param.Value}");
        }
        Console.WriteLine("\n");
    }

    public static string FormatResumeRightSide(bool value)
    {
        if(value) return "ON";
        return "OFF";
    }
}