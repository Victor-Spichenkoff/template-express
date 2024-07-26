using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.IO;
using TemplateExpress.Steps;
using TemplateExpress.Utils;

namespace ApiAutomator;

class Program
{
    static void Main(string[] args)
    {
        UserInitalizationArgs Options = new (args);
        CreatePackageJson.CreateDefault(true);
    }
}