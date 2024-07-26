using TemplateExpress.Utils;

namespace TemplateExpress.Implements;

class TypeScript
{
    public static void Add(bool dev = false)
    {
        Console.WriteLine("\n[RUNNING] Starting TypeScript...");
        
        if(dev)
        {
            // RunCommand.Run("cd../tests && npm install typescript ts-node @types/node @types/express --save-dev");
            RunCommand.Run("cd ../tests");
            RunCommand.Run("cd ../tests && ls", true);
        }
        
        if(!dev)
        {
            RunCommand.Run("cd../tests && npm install typescript ts-node @types/node @types/express --save-dev");
        }
        Console.WriteLine("[INFO] Added TypeScript");
    }
}