#load "MaBiblio.csx"
using System.Diagnostics;

var args = Env.ScriptArgs;

CreerDossier(args);

//EcrireLog("Source001", "Mon message de test", EventLogEntryType.Information, 4055);