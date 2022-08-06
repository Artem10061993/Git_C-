Console.Write("Введите имя пользватедя: ");
string username = Console.ReadLine();

if(username.ToLower() == "артем")
{
    
    Console.WriteLine("УРА Привет Артем!");

}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}