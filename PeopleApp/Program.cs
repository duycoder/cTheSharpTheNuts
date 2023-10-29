//int solve(int n)
//{
//    int sum = 0;
//    int k = 2;
//    while(n > 1)
//    {
//        while(n % k == 0)
//        {
//            n /= k;
//            sum += k;
//        }
//        k++;
//    }
//    return sum;
//}


//int n = 24;

//while(n != solve(n))
//{
//    n = solve(n);
//}

//WriteLine(n);


//var address = new
//{
//    adress = "105 Elm Street",
//    city = "Atlanta",
//    state = "GA",
//    postalCode = "30339"
//};

//WriteLine("{0}", address.GetType().ToString());


//using PeopleApp;

//double pi = "3.1415926535".ToDouble();
//WriteLine(pi);


//using PeopleApp;

//var myWidget = new MyWidget();


//read files
//check lines


//using System.Data.SqlClient;
//using System.Text.RegularExpressions;

//try
//{
//    var path = @"C:\Users\Dell\Desktop\trans.txt";
//    var lines = File.ReadAllLines(path);
//    var linesCount = lines.Length;
//    var connString = "Data Source=D-LAP\\SQLEXPRESS;Initial Catalog=MoneyUsed;User ID=sa;Password=12345678";
//    var insertQuery = "INSERT INTO Transactions (Amount, Note, CreatedDate) VALUES (@Amount, @Note, @CreatedDate)";
//    using (var conn = new SqlConnection(connString))
//    {
//        conn.Open();
//        var currLine = 0;
//        DateTime day = DateTime.Now;
//        while (currLine < linesCount)
//        {
//            var text = lines[currLine];
//            var regexDate = @"^(?:[^a-zA-Z]*|\d\/\d)$";

//            if (!string.IsNullOrEmpty(text))
//            {
//                var isDay = Regex.Match(text, regexDate);
//                if (isDay.Success)
//                {
//                    var daySplit = text.Split('/');
//                    day = new DateTime(2023, int.Parse(daySplit[1]), int.Parse(daySplit[0]));
//                }
//                else
//                {
//                    var trans = text.Split('k');
//                    if (trans.Any())
//                    {
//                        var amountDesc = trans[0];
//                        var desc = trans[1].Trim();

//                        amountDesc = amountDesc.Trim() + "000";


//                        using (SqlCommand command = new SqlCommand(insertQuery, conn))
//                        {
//                            // Parameters for the INSERT statement
//                            command.Parameters.AddWithValue("@Amount", decimal.Parse(amountDesc)); // Use the current date and time
//                            command.Parameters.AddWithValue("@Note", desc);
//                            command.Parameters.AddWithValue("@CreatedDate", day);

//                            // Execute the INSERT query
//                            int rowsAffected = command.ExecuteNonQuery();

//                            if (rowsAffected > 0)
//                            {
//                                Console.WriteLine("Data inserted successfully.");
//                            }
//                            else
//                            {
//                                Console.WriteLine("No rows were inserted.");
//                            }
//                        }
//                    }
//                }
//            }
//            currLine++;
//        }
//    }
//}
//catch (IOException ex)
//{
//    WriteLine(ex.Message);
//}

//WriteLine("DONE");

//string[] presidents = {
//"Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland",
//"Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield",
//"Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
//"Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley",
//"Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft",
//"Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"};
//IEnumerable<string> items = presidents.Where(s =>  Char.IsLower(s[4]));
//Console.WriteLine("After the query.");
//foreach (string item in items)
//{
//    Console.WriteLine(item);
//}    


/**
 * fucking deferred
 */

int[] intArray = new int[] { 1, 2, 3 };
IEnumerable<int> ints = intArray.Select(i => i);

foreach(int i in ints)
{
    Console.WriteLine(i);
}

//change
intArray[0] = 5;

Console.WriteLine("--------");

foreach (int i in ints)
{
    Console.WriteLine(i);
}

string hello = "test";