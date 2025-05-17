// ENTRADA DE INTEGER

string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter a number between 1 and 10");

do
{
  readResult = Console.ReadLine();
  validNumber = int.TryParse(readResult, out numericValue);
  if (!validNumber)
  {
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
  }
  else if (numericValue > 10 || numericValue < 1)
  {
    Console.WriteLine($"You entered {numericValue}. Please enter a number between 1 and 10.");
    validNumber = false;
  }
  else Console.WriteLine($"Your input value {numericValue} has been accepted.");
} while (!validNumber);


// ENTRADA DE STRING

bool validRole = false;
string[] validRoles = { "administrator", "manager", "user" };

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
  readResult = Console.ReadLine();
  string role = (readResult ?? "").Trim().ToLower();

  if (Array.Exists(validRoles, r => r == role))
  {
    string capitalizedRole = char.ToUpper(role[0]) + role.Substring(1);  // Capitalizo el rol
    Console.WriteLine($"Your input value {capitalizedRole} has been accepted.");
    validRole = true;
  }
  else
    Console.WriteLine($"The role name that you entered, '{readResult}' is not valid. Enter your role name (Administrator, Manager, or User)");
} while (!validRole);


// SEPARACIÓN DE STRING

string[] myStrings = new string[2] {
  "I like pizza. I like roast chicken. I like salad",
  "I like all three of the menu choices"
};

int periodLocation = 0;

foreach (string myStringOriginal in myStrings)
{
  string myString = myStringOriginal;
  periodLocation = myString.IndexOf(".");
  while (periodLocation != -1)
  {
    string sentence = myString.Substring(0, periodLocation);
    Console.WriteLine(sentence.TrimStart());
    myString = myString.Remove(0, periodLocation + 1).TrimStart();
    periodLocation = myString.IndexOf(".");
  }
  Console.WriteLine(myString.TrimStart());
}