@echo off
cls

set releasePath=%cd%\..\Release

Squirrel pack --packId "MoveGeneratorDebug" --packTitle "Move Generator" --packAuthors "TheCrafters001" --packVersion "1.0.0" --framework net6.0 --packDirectory "..\src\Move Generator\bin\Debug\net6.0-windows" --releaseDir %releasePath% --verbose

pause