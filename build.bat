@ECHO OFF
SETLOCAL

start dotnet restore KBL.ExceptionManager && dotnet build KBL.ExceptionManager

xcopy ".\KBL.ExceptionManager\KBL.ExceptionManager.Base\bin\Release\netcoreapp2.0\*.dll" ".\nuget\lib\netcoreapp2.0\" /Y
