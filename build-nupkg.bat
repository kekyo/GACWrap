@echo off

rem GACWrap - Managed GAC API Wrappers
rem http://blogs.msdn.com/b/junfeng/archive/2004/09/14/229649.aspx

.nuget\nuget pack GACWrap.nuspec -Prop Version=1.0.0 -Prop Configuration=Release
