@echo off
cls

set releasePath=%cd%\..\Release

Squirrel pack --packId "Move-Generator" --packTitle "Move Generator" --packAuthors "TheCrafters001" --packVersion "1.0.0" --framework net6.0 --packDirectory "..\src\Move Generator\bin\Release\net6.0-windows" --releaseDir %releasePath%

pause