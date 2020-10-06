#r "System"
#r "System.Management.Automation"

using System.Management.Automation;

using(PowerShell ps = PowerShell.Create())
{
    ps.AddCommand("Get-Process");

    foreach (PSObject item in ps.Invoke())
    {
        Console.WriteLine("{0,-24} {1}",
                            item.Members["ProcessName"].Value,
                            item.Members["Id"].Value);
    }
}