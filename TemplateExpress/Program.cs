using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.IO;
using TemplateExpress.CreateFiles;
using TemplateExpress.Implements;

// using TemplateExpress.Steps;
using TemplateExpress.Utils;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            UserInitalizationArgs Options = new(args);
            Console.Clear();
            CreatePackageJson.CreateDefault(Options);
            CreateApp.Create(Options);
            Express.Add(Options);
            TypeScript.Add(Options);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            System.Environment.Exit(1);
        }
        // CreatePackageJson.CreateDefault(Options.OnlyJs);
        // CreateApp.Create(Options.OnlyJs);
        // Express.Add();

        //Para DEV
        // Console.Clear();
        // CreatePackageJson.CreateDefault(Options);
        // CreateApp.Create(Options);
        // Express.Add(true);
        // TypeScript.Add(true);
    }
}