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

    public static bool YesOrNo(string label, bool enterValue = true)
    {
        Console.Write(label);
        string? res = Console.ReadLine();
        if (res == null || res.Trim() == "")
            return enterValue;

        bool booleanRes = res.Trim().ToLower()[0] == 'y';
        
        return booleanRes;
    }
}