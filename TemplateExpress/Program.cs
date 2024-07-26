using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.IO;
using TemplateExpress.CreateFiles;
using TemplateExpress.Implements;

// using TemplateExpress.Steps;
using TemplateExpress.Utils;

namespace ApiAutomator;

class Program
{
    static void Main(string[] args)
    {
        UserInitalizationArgs Options = new (args);
        // CreatePackageJson.CreateDefault();
        // CreateApp.Create();

        //Para DEV
        Console.Clear();
        CreatePackageJson.CreateDefault(Options.OnlyJs, dev:true);
        CreateApp.Create(Options.OnlyJs, dev:true);
        Express.Add(true);
    }
}