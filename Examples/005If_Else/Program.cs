Console.Write("Введите имя пользователя: ");
string UserName = Console.ReadLine();

if(UserName.ToLower() == "маша")
{   
    Console.WriteLine("Давно не виделись, Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(UserName);
}