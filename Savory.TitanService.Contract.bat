msbuild Savory.TitanService.Contract\Savory.TitanService.Contract.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.TitanService.Contract.xml;DebugType=none

nuget pack Savory.TitanService.Contract.nuspec

move /y Savory.TitanService.Contract.*.nupkg D:\LocalWebRoot\SavoryNuget\Packages

pause