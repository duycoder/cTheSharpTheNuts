﻿//using System.Reflection;

//Assembly? myApp = Assembly.GetEntryAssembly();
//if (myApp == null) return;

//foreach(AssemblyName name in myApp.GetReferencedAssemblies())
//{
//    Assembly a = Assembly.Load(name);
//    int methodCount = 0;

//    foreach(TypeInfo t in a.DefinedTypes)
//    {
//        methodCount += t.GetMethods().Count();
//    }

//    Console.WriteLine(
//        "{0:N0} types with {1:N0} methods in {2} assembly.", 
//        arg0: a.DefinedTypes.Count(), 
//        arg1: methodCount,
//        arg2: name.Name
//        );
//}

//System.Data.DataSet ds;
//HttpClient client;

//string horizontalLine = new('-', count: 74);
//Console.WriteLine(horizontalLine);
//string grinningEmoji = char.ConvertFromUtf32(0x1F600);
//Console.WriteLine(grinningEmoji);

//Console.OutputEncoding = System.Text.Encoding.UTF8;
//string grinningEmoji = char.ConvertFromUtf32(0x1F600);
//Console.WriteLine(grinningEmoji);

//string fullNameWithTabSeperator = "Bob\tSmith";
//Console.WriteLine(fullNameWithTabSeperator);


//string xml = """
//    <person age="50">
//        <first_name>Mark</first_name>
//    </person>
//    """;

var person = new { FirstName = "Alice", Age = 56 };

string json = $@"
    {{
     ""first_name"": ""{person.FirstName}"",
     ""age"": {person.Age},
     ""calculation"": {1 + 2}
    }}";
Console.WriteLine(json);











