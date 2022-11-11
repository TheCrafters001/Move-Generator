@echo off
cls

set releasePath=%cd%\..\Release
set buildPath=%cd%\..\src\Move Generator\bin\Release\net6.0-windows

Squirrel pack --packId "Move_Generator" --packTitle "Move Generator" --packAuthors "TheCrafters001" --packVersion "0.0.1" --framework net6.0 --packDirectory "%buildPath%" --releaseDir %releasePath%

pause