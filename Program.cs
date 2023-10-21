// See https://aka.ms/new-console-template for more information
/*string greeting = "Hello World!";
int score = 94;
double discount = 43.56;
char grade = 'A';
bool isCsharpFun = true;
float odds = 20.44f;
decimal money = 300.992M;
long phone = 08025207486;
Console.WriteLine(greeting);
*/
/*Console.WriteLine("Hello, World!");
Console.WriteLine("I have started coding with C#");
Console.WriteLine("It is sweeet mehn");
*/

/*char name = 'A';
int newname = name;
Console.WriteLine(newname);

double score = 45.56;
int newscore = (int)score;
Console.WriteLine(newscore);

string h = "89";
int h1 = Convert.ToInt32(h);
Console.WriteLine(h1);
*/
// FirstName
//LastName
//Age
//Location
//Fav Color
// Hobby

using System.Drawing;

Console.Write("Enter first name: ");
string FirstName = Console.ReadLine();

Console.WriteLine($"Your name is: {FirstName}");

Console.Write("Enter Last name: ");
string LastName = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your Location: ");
string Location = Console.ReadLine();

Console.Write("Enter Fav Color: ");
string? Fav_color = Console.ReadLine();

Console.Write("Enter your Hobby: ");
string? Hobby = Console.ReadLine();
Console.WriteLine("%s", Hobby);

string composition = "My name is " + FirstName + " " + LastName + ".\n" + "I am " + age + "Years old.\n" + "I live in " + Location + "." + "My favorite color is color " + Fav_color + ". I love " + Hobby;
Console.WriteLine(composition);

string composition_interpolation = $"My name is {FirstName} {LastName}. I am {age} Years old. I live in {Location}. My favorite color is {Fav_color}. I love {Hobby}";
Console.WriteLine(composition_interpolation);
int count = composition_interpolation.Length;
int index = composition.IndexOf('n');
Console.WriteLine($"{count}. The letter n is at the index of {index}");
int mult = count * 5;
Console.WriteLine(mult);