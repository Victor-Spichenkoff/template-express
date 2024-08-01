namespace TemplateExpress.Utils;


public class UserInitalizationArgs
{
    public bool NoPrisma = false;
    public bool OnlyJs = false;
    public string OutputName = "express";
    public bool CreateOnCurrentDir = false;
    public bool Stock = false;
    public bool NoMiddlewares = false;
    public bool OpenWithCode = false;


    public UserInitalizationArgs(string[] args)
    {
        if(args.Contains("-h") || args.Contains("--help"))
        {
            Help.Show();
            return;
        }

        if(args.Contains("--config"))
            SetArgumentsFromUser();

        SetArguments(args);
    }

    public void SetArguments(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            var currentArg = args[i];
            if (currentArg == "--no-prisma")
                NoPrisma = true;

            if (currentArg == "--js")
                OnlyJs = true;


            if(currentArg == "--stock")
                Stock = true;

            if(currentArg == "--no-middleware")
                NoMiddlewares = true;   

            if(currentArg == "--code")
                OpenWithCode = true;

            if(currentArg == "--stock")
            {
                Stock = true; 
                NoPrisma = true;
                NoMiddlewares = true;
            }

            if(currentArg == "--current-dir")
            {
                CreateOnCurrentDir = true;
                OutputName = "";
            }

            //mais chatos
            if (currentArg == "-o" && !args.Contains("--current-dir"))
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


    public void SetArgumentsFromUser()
    {
        CreateOnCurrentDir = Input.YesOrNo("Create on Current Directory: (n) ", false);

        if(!CreateOnCurrentDir)
        {
            string res = Input.String("Output folder name: (express) ");
            OutputName = res == "" || res == "y" ? "express" : res;
        }
        else
        {
            OutputName = "";
        }

        OnlyJs = !Input.YesOrNo("Use TypeScript: (y) ");

        Stock = Input.YesOrNo("Stock Project: (n) ", false);

        if(Stock)
        {
            NoPrisma = true;
            NoMiddlewares = true;
            Console.WriteLine(NoPrisma);
        }
        else
        {
            NoPrisma = !Input.YesOrNo("Use Prisma: (y) ");
            NoMiddlewares = !Input.YesOrNo("Use Middlewares: (y) ");
        }
        OpenWithCode = Input.YesOrNo("Open on VSCode: (n) ", false);
    }
}