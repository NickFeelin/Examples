Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "санька")
{
    Console.WriteLine("Ура! Это же Санька - моя любимая жена!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
