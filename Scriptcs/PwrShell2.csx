#r "System"
#r "System.Management.Automation"

using System.Management.Automation;
using System.IO;

StreamReader stream = new StreamReader("affiche.ps1");

string script = stream.ReadToEnd();

using (PowerShell ps = PowerShell.Create())
{
    ps.AddScript(script);
    ps.Invoke();

    Console.WriteLine("Les dossiers sont crées");
}