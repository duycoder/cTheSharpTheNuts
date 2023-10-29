//using Microsoft.Extensions.Configuration;
//using System.Diagnostics;
//using System.Runtime.CompilerServices;

//var logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

//TextWriterTraceListener logFile = new(File.CreateText(logPath));
//Trace.Listeners.Add(logFile);
//Trace.AutoFlush = true;

//var dir = Directory.GetCurrentDirectory();
//Console.WriteLine("Reading from appsettings.json in {0}", arg0: dir);

//ConfigurationBuilder builder = new();
//builder.SetBasePath(dir);
//builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

//IConfigurationRoot config = builder.Build();
//TraceSwitch ts = new(displayName: "PacktSwitch", description: "This switch is set via JSON config.");
//config.GetSection("PacktSwitch").Bind(ts);

//Trace.WriteLineIf(ts.TraceError, "Trace Error");
//Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
//Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
//Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

//int unitsInStock = 12;
////LogSourceDetails(unitsInStock > 10);
//Console.ReadLine();