using Variables;
//int e = 11;
//int f = 3;
//double g = 11.0;
//WriteLine($"g is {g:N1}, f is {f}");
//WriteLine($"g / f = {g / f}");

//bool a = true;
//bool b = false;
//WriteLine($"AND |a |b");
//WriteLine($"a | {a & a,-5} | {a & b,-5}");
//WriteLine($"b | {b & a,-5} | {b & b,-5}");
//WriteLine();
//WriteLine($"OR |a | b");
//WriteLine($"a | {a | a,-5} | {a | b,-5}");
//WriteLine($"b | {b | a,-5} | {b | b,-5}");
//WriteLine();
//WriteLine($"XOR |a |b");
//WriteLine($"a | {a ^ a,-5} | {a ^ b,-5}");
//WriteLine($"b | {b ^ a,-5} | {b ^ b,-5}");

//static bool DoStuff()
//{
//    WriteLine("I am doing some stuff");
//    return true;
//}

//WriteLine();
//WriteLine($"a & DoStuff() = {a ^ DoStuff()}");
//WriteLine($"b & DoStuff() = {b ^ DoStuff()}");

//int a = 10;
//int b = 6;
//WriteLine($"a = {a}");
//WriteLine($"b = {b}");
//WriteLine($"a & b = {a & b}");
//WriteLine($"a ^ b = {a ^ b}");
//WriteLine($"a << 3 = {a << 3}");
//WriteLine($"a * 8 = {a * 8}");
//WriteLine($"b >> 1 = {b >> 1}");

//static string ToBinaryString(int value)
//{
//    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
//}

//WriteLine();
//WriteLine("Outputting integers as binary");
//WriteLine($"a = {ToBinaryString(a)}");
//WriteLine($"b = {ToBinaryString(b)}");
//WriteLine($"a & b = {ToBinaryString(a & b)}");
//WriteLine($"a | b = {ToBinaryString(a | b)}");
//WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

//int age = 50;
//WriteLine($"The {nameof(age)} variable uses {sizeof(int)} bytes of memory.");

//string password = "ninja";
//if(password.Length < 8)
//{
//    WriteLine("Your password is too short. Use atleast 8 characters.");
//}
//else
//{
//    WriteLine("Your password is too strong");
//}
//object o = "3";
//int j = 4;

//if (o is int i)
//{
//    WriteLine($"{i} x {j} = {i * j}");
//}
//else
//{
//    WriteLine("o is not an int so it cannot multiply.");
//}

//int number = Random.Shared.Next(1, 7);
//WriteLine($"My random number is {number}");
//switch(number)
//{
//    case 1:
//        WriteLine("one");
//        break;
//    case 2:
//        WriteLine("two");
//        goto case 1;
//    case 3:
//    case 4:
//        WriteLine("Three or four");
//        goto case 1;
//    case 5:
//        goto A_label;
//    default:
//        WriteLine("Default");
//        break;
//}
//WriteLine("After end of switch");
//A_label:
//WriteLine($"After A_Label");


Animal?[] animals = new Animal?[]
{
    new Cat{Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic=true},
    null,
    new Cat{Name = "Mufasa",Born = new (year: 1994, month: 6, day: 12)},
    new Spider{Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true},
    new Spider{Name = "Captain Furry", Born = DateTime.Today}
};

//foreach (Animal? animal in animals)
//{
//    string message;
//    switch (animal)
//    {
//        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
//            message = $"The cat named {fourLeggedCat.Name} has four legs.";
//            break;
//        case Cat wildCat when wildCat.IsDomestic == false:
//            message = $"The non-domestic cat is named {wildCat.Name}";
//            break;
//        case Cat cat:
//            message = $"The cat is named {cat.Name}";
//            break;
//        default:
//            message = $"The animal named {animal.Name} is a {animal.GetType().Name}";
//            break;
//        case Spider spider when spider.IsPoisonous:
//            message = $"The {spider.Name} spider is poisonous. Run!";
//            break;
//        case null:
//            message = "The animal is null.";
//            break;
//    }
//    WriteLine($"switch statement: {message}");
//}

//foreach(var animal in animals)
//{
//    string message = "";
//    message = animal switch
//    {
//        Cat fourLeggedCat when fourLeggedCat.Legs == 4 => $"The cat {fourLeggedCat.Name} has four legs.",
//        Cat wildCat when wildCat.IsDomestic == false => $"The non-domestic cat is named {wildCat.Name}",
//        Cat cat => $"The cat is named {cat.Name}",
//        Spider spider when spider.IsPoisonous => $"The {spider.Name} spider is poisonous. Run!",
//        null => "The animal is null.",
//        _ => $"The animal named {animal.Name} is a {animal.GetType().Name}"
//    };
//    WriteLine($"switch expression: {message}");
//}

//int x = 0;
//while(x < 10)
//{
//    WriteLine(x);
//    x++;
//}

//string? password;
//do
//{
//    Write("Enter your password:");
//    password = ReadLine();
//} while (password != $"Pa$$w0rd");
//WriteLine("Correct!");

//for(int y = 1; y <= 10;y++)
//{
//    WriteLine(y);
//}

//string[] names = { "Adam", "Barry", "Charlie" };
//foreach(string name in names)
//{
//    WriteLine($"{name} has {name.Length} characters");
//}


//string[] names;

//names = new string[4];
//names[0] = "Kate";
//names[1] = "Jack";
//names[2] = "Rebecca";
//names[3] = "Tom";

//for (int i = 0; i < names.Length; i++)
//{
//    WriteLine(names[i]);
//}


//string[,] grid = new[,]
//{
//    {"Alpha", "Beta", "Gamma", "Delta" },
//    {"Anne", "Ben", "Charlie", "Doug" },
//    {"Aardvark", "Bear", "Cat", "Dog" }
//};

//WriteLine($"Lower bound of the first dimension is: {grid.GetLowerBound(0)}");
//WriteLine($"Upper bound of the first dimension is: {grid.GetUpperBound(1)}");

//for (int row = 0; row <= grid.GetUpperBound(0); row++)
//{
//    for (int col = 0; col <= grid.GetUpperBound(1); col++)
//    {
//        WriteLine($"Row {row}, Column {col}: {grid[row, col]}");
//    }
//}

//string[,] grid = new string[3, 4];

//grid[0, 0] = "Alpha";
//grid[0, 1] = "Beta";
//grid[2, 3] = "Dog";

//string[][] jagged = new[]
//{
//    new[] {"Alpha", "Beta", "Gamma"},
//    new[] {"Anne", "Ben", "Charlie", "Doug"},
//    new[] {"Aardvark", "Bear"}
//};

//for (int row = 0; row <= jagged.GetUpperBound(0); row++)
//{
//    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
//    {
//        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
//    }
//}

//int[] sequentialNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] oneTwoNumbers = new[] { 1, 2 };
//int[] oneTwoTenNumbers = new[] { 1, 2, 10 };
//int[] onTwoThreeTenNumbers = new[] { 1, 2, 3, 10 };
//int[] primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
//int[] fibonacciNumbers = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
//int[] emptyNumbers = new int[] { };
//int[] threeNumbers = new int[] { 9, 7, 5 };
//int[] sixNumbers = new int[] { 9, 7, 5, 4, 2, 10 };

//static string CheckSwitch(int[] values) => values switch
//{
//    [] => "Empty array",
//    [1,2,_, 10] => "Contains 1, 2 any single number, 10",
//    [1,2,.., 10] => "Contains 1,2, any range including empty, 10",
//    [1,2] => "Contains 1 then 2",
//    [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}",
//    [0, _] => "Starts with 0, then one other number",
//    [0, ..] => "Starts with 0, then any range of numbers",
//    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
//    [..] => "Any times in any order"
//};
