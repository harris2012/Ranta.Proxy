msbuild Ranta.Proxy.Net40\Ranta.Proxy.Net40.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.Proxy.xml;DebugType=none

msbuild Ranta.Proxy.Net45\Ranta.Proxy.Net45.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.Proxy.xml;DebugType=none

nuget pack Ranta.Proxy.nuspec

pause