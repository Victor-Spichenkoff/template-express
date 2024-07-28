namespace TemplateExpress.Utils;

public class Logs
{
    public static void CurrentStep(string title)
    {
        // Console.WriteLine($"\n\n----- {title.ToUpper()} -----");
        const int totalLength = 50; // Defina o comprimento total desejado para a linha
        title = $" {title.ToUpper()} ";
        int dashCount = (totalLength - title.Length) / 2;

        string dashes = new string('-', dashCount);
        string line = $"{dashes}{title}{dashes}";

        // Se o título for ímpar, adicione um traço extra no final para ajustar o comprimento total
        if (line.Length < totalLength)
        {
            line += "-";
        }

        Console.WriteLine($"\n\n{line}");

    }
}