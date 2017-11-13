Set-Location .\MyCustomTestLibrary
dotnet pack -c Release -o ..\nupkg
Set-Location ..\
Set-Location .\CustomMsBuildTask1
dotnet pack -c Release -o ..\nupkg
Set-Location ..\
Set-Location .\CustomMsBuildTask2
dotnet pack -c Release -o ..\nupkg
Set-Location ..\