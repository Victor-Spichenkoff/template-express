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
        UserInitalizationArgs Options = new (args);
        // CreatePackageJson.CreateDefault(Options.OnlyJs);
        // CreateApp.Create(Options.OnlyJs);
        // Express.Add();

        //Para DEV
        Console.Clear();
        // CreatePackageJson.CreateDefault(Options.OnlyJs, dev:true);
        // CreateApp.Create(Options.OnlyJs, dev:true);
        // Express.Add(true);
        TypeScript.Add(true);
    }
}