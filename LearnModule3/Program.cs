using System;

public class User 
{    
    private int _age;
    public int Age
    {
        get { return _age; }  
    }
    private DateTime _dateOfBirth;
    public DateTime DateOfBirth { get => _dateOfBirth; }       
    public string? Name { get; set; }   
    

    public bool isValidDate(string? dateOfBirth) => DateTime.TryParse(dateOfBirth, out _dateOfBirth);
    public bool isValidAge() 
    {
       bool isValidAge =  (DateTime.Now.Date.Year - _dateOfBirth.Date.Year) < 100;

        if (isValidAge) 
        {
            _age = DateTime.Now.Date.Year - _dateOfBirth.Date.Year;
            return true;
        }
        else
        {
            return false;
        }
    }

}

class MainClass
{  
    public static void Main(string[] args)
    {
        User user = new();

        Console.WriteLine("Введите имя");
        user.Name = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("\nВведите дату рождения");

            if (!user.isValidDate(Console.ReadLine()))
            {
                Console.WriteLine("\nНекорректная дата рождения!");
                continue;

            }
            else if (!user.isValidAge()) 
            {
                Console.WriteLine("\nНекорректный возраст!");
                continue;
            }
            else
            {
                break;
            }          
        }        

        Console.WriteLine($"\nВаше имя: { user.Name}");
        Console.WriteLine($"Ваша дата рождения: {user.DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Ваш возраст: {user.Age}");
    }
}
