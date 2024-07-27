namespace TemplateExpress.Utils;


public class UserInitalizationArgs
{
    public bool NoPrisma = false;
    public bool OnlyJs = false;
    public string OutputName = "express";
    public bool CreateOnCurrentDir = false;
    public UserInitalizationArgs(string[] args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
        SetArguments(args);
        // Console.WriteLine("apos construtor: " + OutputName);
    }

    public void SetArguments(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            var currentArg = args[i];
            Console.WriteLine(currentArg == "-o");
            if (currentArg == "--no-prisma")
                NoPrisma = true;

            if (currentArg == "--js")
                OnlyJs = true;

            if(currentArg == "--current-dir")
                CreateOnCurrentDir = true;

            //mais chatos
            if (currentArg == "-o")
            {
                if (i + 1 < args.Length)
                {
                    OutputName = args[i + 1];
                    i++;
                }
                else
                {
                    throw new Exception("[ERROR] You must pass the folder name after \"-o\"");
                }

            }

        }
    }
}