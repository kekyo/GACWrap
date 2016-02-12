using System.Reflection;

[assembly: AssemblyTrademark("GACWrap")]
[assembly: AssemblyDescription("This implements managed wrappers to GAC API Interfaces. See also: http://blogs.msdn.com/b/junfeng/archive/2004/09/14/229649.aspx")]

[assembly: AssemblyCompany("Junfeng Zhang")]
[assembly: AssemblyProduct("GACWrap")]
[assembly: AssemblyCopyright("Copyright (c) Junfeng Zhang")]

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif
