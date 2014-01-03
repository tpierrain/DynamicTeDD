using System.Reflection;
using JetBrains.ActionManagement;
using JetBrains.Application.PluginSupport;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("NFluent.DynamicTeDD")]
[assembly: AssemblyDescription("A ReSharper plug-in to make your TDD more fluent via dynamic usage. 1/ You start defining your contract using a dynamic 'modeling clay' instance from within a test (compiling RED) 2/ The plugin replace your dynamic instance with a non-dynamic skeleton code (RED) 3/ You implement the dynamic skeleton code to make your test pass (GREEN)")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Thomas PIERRAIN, from Rui CARVALHO's original idea")]
[assembly: AssemblyProduct("NFluent.DynamicTeDD")]
[assembly: AssemblyCopyright("Copyright © Thomas PIERRAIN, from Rui CARVALHO's original idea, 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: ActionsXml("NFluent.DynamicTeDD.Actions.xml")]

// The following information is displayed by ReSharper in the Plugins dialog
[assembly: PluginTitle("NFluent.DynamicTeDD")]
[assembly: PluginDescription("A ReSharper plug-in to make your TDD more fluent via dynamic usage. 1/ You start defining your contract using a dynamic 'modeling clay' instance from within a test (compiling RED) 2/ The plugin replace your dynamic instance with a non-dynamic skeleton code (RED) 3/ You implement the dynamic skeleton code to make your test pass (GREEN)")]
[assembly: PluginVendor("Thomas PIERRAIN, from Rui CARVALHO's original idea")]
