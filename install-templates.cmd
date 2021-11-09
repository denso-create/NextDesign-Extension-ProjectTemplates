
rem uninstall templates
dotnet new --uninstall NextDesign.Extension.ProjectTemplates

rem pack 
dotnet pack src -o ./NuPkgs

rem install templates
dotnet new --install ./NuPkgs/*.nupkg

