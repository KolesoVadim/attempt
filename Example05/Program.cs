Console.Write("Enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "mia")
{
    Console.WriteLine("yoop, Mia");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}