﻿/**
 * 29/10/2023
 */

string[] presidents = {
"Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland",
"Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield",
"Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
"Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley",
"Monroe", "Nixon", "Obama", "Pierce", "Polk", "Reagan", "Roosevelt",
"Taft", "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"};

string pres = presidents.Where(p => p.StartsWith("Lin")).First();
Console.WriteLine(pres);

/**
 *  the fuck is legacy collection
 */