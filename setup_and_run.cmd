@REM @echo off
@REM echo Installing dependencies...

@REM :: Navigate to the backend project directory
@REM cd /d d:/PROJECTS/DatingAppCourse/demo/DatingApp/API

@REM :: Restore .NET dependencies
@REM dotnet restore

@REM :: Build the project
@REM dotnet build

@REM :: Apply database migrations
@REM dotnet ef database update

:: Navigate to the frontend project directory
cd /d d:/PROJECTS/DatingAppCourse/demo/DatingApp/client

@REM :: Install Node.js dependencies
@REM npm install

@REM echo Dependencies installed and database updated.

@REM echo Starting the backend and frontend...

:: Start the backend
start dotnet run --project ../API

:: Start the frontend
start ng serve

pause