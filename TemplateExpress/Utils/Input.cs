namespace TemplateExpress.Utils;

public static class Input
{
    public static string String(string label)
    {
        Console.Write(label);
        string? res = Console.ReadLine();
        if (res == null)
            return String(label);
        return res;
    }

    public static bool YesOrNo(string label)
    {
        Console.Write(label);
        string? res = Console.ReadLine();
        if (res == null)
            return YesOrNo(label);

        bool booleanRes = res.Trim().ToLower()[1] == 'y';
        
        return booleanRes;
    }
}