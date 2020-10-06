#r "System.dll"
#r "mscorlib"
using System.Diagnostics;

public void EcrireLog(string source, string message, EventLogEntryType typeEnv, int id)
{
    try
    {
        EventLog.WriteEntry(source, message, typeEnv, id);
        Console.WriteLine("Message ecrit avec succes");
    }
    catch (Exception e)
    {
        Console.WriteLine("Quelque chose ne vas pas");
        Console.WriteLine(e.Message);
    }
}


public void CreerDossier(TReadOnlyList<string> args)
{
    bool flag = Directory.Exists(args[0]);

    if(!flag)
    {
        Console.WriteLine("Le dossier n'existe pas");
        Console.WriteLine("Création du dossier");
        Directory.CreateDirectory(args[0]);
    
    }
    else
    {
        Console.WriteLine("Le dossier existe déja");
    }
}