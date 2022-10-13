Console.WriteLine("Введите имя пользователья");
string username = Console.ReadLine();

 if(username.ToLower() == "Маша")

    {
        Console.WriteLine("Ура, это же Маша!");
    }

else 
    {
        Console.WriteLine("Привет, ");
        Console.WriteLine(username);
    }
