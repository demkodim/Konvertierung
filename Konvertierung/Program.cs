//Aufgabe 2
string name = "Dimitri";
Console.WriteLine($"Vorname: {name}");

short age = 17;
string alter = age.ToString();
Console.WriteLine($"Alter: {alter}");

string yes = "Ja";
Console.WriteLine($"Ist C# die erste Programmiersprache, die Sie erlernen?: {yes}");


//Aufgabe 3 
int Dollarzahl = 36;
char Dollar = (char)Dollarzahl;


//Aufgabe 4
string eingabe = Console.ReadLine();
short short_Number = Convert.ToInt16(eingabe);
Console.WriteLine(short_Number / 10);

string eingabe2 = Console.ReadLine();
double double_Number = Convert.ToDouble(eingabe2);
Console.WriteLine(double_Number / 10);