using System;
using TemplateExpress.Utils;

namespace TemplateExpress.Steps;

class CreatePackageJson
{
    public static void CreateDefault(bool dev = false)
    {
        try
        {
            if (dev)
                RunCommand.Run("cd ../tests && npm init -y");
            else
                RunCommand.Run("npm init -y");

            Console.Clear();
        } catch(Exception e)
        {
            bool res = Input.YesOrNo("[ERROR] There's an error while creating package.json.\nSee full log? [y/n] ");
            if(res) Console.WriteLine(e);
            System.Environment.Exit(1);
        }
    }
}