string permission = "Admin|Manager";
int level = 95;

if (permission.Contains("Admin")) 
{
  string msg = level > 55 ? "Welcome Super Admin user." : "Welcome Admin user.";
  Console.WriteLine(msg);
}
else if (permission.Contains("Manager"))
{
  string msg = level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
  Console.WriteLine(msg);
}
else 
{
Console.WriteLine("You do not have sufficient privileges.");
}