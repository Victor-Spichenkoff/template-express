namespace TemplateExpress.Utils;


public class UserInitalizationArgs
{
    public bool NoPrisma;
    public bool OnlyJs = false;
    public string OutputPath = string.Empty;
    public UserInitalizationArgs(string[] args)
    {
        SetArguments(args);
    }

    private void SetArguments(string[] args)
    {
        for(int i=0; i<args.Length; i++)
        {
            var currentArg = args[i];
            if(currentArg == "--no-prisma")
                NoPrisma = true;
            
            if(currentArg == "--js")
               OnlyJs = true;


            //mais chatos
            if(currentArg == "-o")
            {
                OutputPath=args[i+1];
                i++;
            }
        }
    }
}