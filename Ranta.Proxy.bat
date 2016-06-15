msbuild Ranta.Utility.Net40\Ranta.Utility.Net40.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.Utility.xml;DebugType=none

msbuild Ranta.Utility.Net45\Ranta.Utility.Net45.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.Utility.xml;DebugType=none

nuget pack Ranta.Utility.nuspec

pause