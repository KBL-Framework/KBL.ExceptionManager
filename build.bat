@ECHO OFF
SETLOCAL
SET VERSION=%1
SET NUGET=.\bin\nuget.exe

start dotnet restore KBL.ExceptionManager && dotnet build KBL.ExceptionManager

xcopy ".\KBL.ExceptionManager\KBL.ExceptionManager.Base\bin\Release\netcoreapp2.0\*.dll" ".\nuget\lib\netcoreapp2.0\" /Y

FOR /r %%f IN (*.nuspec) DO (
  echo "packing... hovno"
  %NUGET% pack %%f -Version %VERSION%
)
