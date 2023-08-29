// See https://aka.ms/new-console-template for more information
using Objects_and_Strings;

//This makes it a reference and adds it to the statements "Brand," "Type," and "IsOn" when the program starts
Computer myComputer = new Computer("Apple","All-in-One", true);
IBootUp mybootUp = myComputer;
Console.WriteLine(myComputer.Equals(mybootUp));

//creates a new reference for this that is distinct from the previous one because it is for myOtherComputer.
Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
Console.WriteLine(myComputer.Equals(myOtherComputer));

//MyString converts myComputer into a string, equals myOtherString to myString, and then equals myComputer.
string myString = myComputer.ToString();
string myOtherString = myString;

//begins with the "Computer" greeting the user.
myString = "Hi";

//the line that is saved in both myString and myOtherString is written.
Console.WriteLine(myString);
Console.WriteLine(myOtherString);

//Makes myComputer, myOtherComputer, and myString equal.
Console.WriteLine(myString == myComputer.ToString());
Console.WriteLine(myString == myOtherComputer.ToString());

//while obtaining the type, writes the sentence that is stored in myComputer and myBootUp.
Console.WriteLine(myComputer.GetType());
Console.WriteLine(myComputer.GetType());

//Use the PowerOnOff command on "myOtherComputer" to determine if it will boot up or shut down.
myOtherComputer.powerOnOff();

//equals the variable to myOtherComputer and writes the line for myString.
Console.WriteLine(myString == myOtherComputer.ToString());
Console.WriteLine(myString);
Console.WriteLine(myOtherComputer.ToString());

//The string contains the variable/letter "i" in the sentence.
Console.WriteLine(myString.Contains('i'));

//raises the string's case.
Console.WriteLine(myString.ToUpper());